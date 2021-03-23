using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Command.Cores.Dispatchers
{
    public interface IDispatcher : ICommandRegister, ICommandDispatcher
    {
    }
}