using Sol_Command.Cores.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Command.Cores.Dispatchers
{
    public interface ICommandRegister
    {
        void Register(IBaseCommand baseCommand);
    }
}