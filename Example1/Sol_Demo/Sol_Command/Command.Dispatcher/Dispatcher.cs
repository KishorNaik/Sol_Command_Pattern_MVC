using Sol_Command.Cores.Commands;
using Sol_Command.Cores.Dispatchers;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Command.Command.Dispatcher
{
    public sealed class Dispatcher : IDispatcher
    {
        private readonly ConcurrentBag<IBaseCommand> baseCommands = new ConcurrentBag<IBaseCommand>();

        private Task<IBaseCommand> GetCommandAsync(Type type)
        {
            return Task.Run(() =>
            {
                var test =
                baseCommands
                .FirstOrDefault((command) =>
                {
                    if (command.GetType().GetInterface(type.FullName) == type || command.GetType() == type)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                });

                return test;
            });
        }

        async Task ICommandDispatcher.DispatchAsync<TRequest>(Type type, TRequest request)
        {
            var command = await GetCommandAsync(type);

            if (command is ICommand<TRequest> invokeCommand)
            {
                await invokeCommand?.HandleAsync(request);
            }
        }

        async Task<TResponse> ICommandDispatcher.DispatchAsync<TRequest, TResponse>(Type type, TRequest request)
        {
            var command = await GetCommandAsync(type);

            if (command is ICommand<TRequest, TResponse> invokeCommand)
            {
                return await invokeCommand?.HandleAsync(request);
            }

            return default(TResponse);
        }

        void ICommandRegister.Register(IBaseCommand command)
        {
            baseCommands.Add(command);
        }
    }
}