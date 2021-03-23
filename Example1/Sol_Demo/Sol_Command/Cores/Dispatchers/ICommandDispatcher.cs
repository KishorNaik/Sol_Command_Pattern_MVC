using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Command.Cores.Dispatchers
{
    public interface ICommandDispatcher
    {
        Task DispatchAsync<TRequest>(Type type, TRequest request);

        Task<TResponse> DispatchAsync<TRequest, TResponse>(Type type, TRequest request);
    }
}