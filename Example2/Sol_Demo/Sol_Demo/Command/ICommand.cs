using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Command
{
    public interface ICommand<TController> where TController : ControllerBase
    {
        IActionResult Execute(TController controller);
    }

    public interface IAsyncCommand<TController> where TController : ControllerBase
    {
        Task<IActionResult> Execute(TController controller);
    }
}
