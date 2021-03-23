using Microsoft.Extensions.DependencyInjection;
using Sol_Command.Command.Dispatcher;
using Sol_Command.Cores.Dispatchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Command.Extensions
{
    public static class CommandConfigurationExtension
    {
        public static void AddCommands(this IServiceCollection services, Action<ICommandRegister, IServiceProvider> config)
        {
            services.AddSingleton<ICommandDispatcher, Dispatcher>((configDispatcher) =>
            {
                var dispatcher = new Dispatcher();
                config?.Invoke(dispatcher, configDispatcher);
                return dispatcher;
            });
        }
    }
}