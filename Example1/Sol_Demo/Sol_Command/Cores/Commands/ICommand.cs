using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Command.Cores.Commands
{
    public interface ICommand<in TRequest> : IBaseCommand
    {
        Task HandleAsync(TRequest request);
    }

    public interface ICommand<in TRequest, TResponse> : IBaseCommand
    {
        Task<TResponse> HandleAsync(TRequest request);
    }
}