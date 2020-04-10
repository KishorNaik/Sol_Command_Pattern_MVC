using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Demo.Command.UsersCommand;
using Sol_Demo.ViewModels;

namespace Sol_Demo.Controllers
{
    public class UsersController : Controller
    {
        public UsersController()
        {
            UserVM = new UsersViewModel();
        }

        [BindProperty]
        public UsersViewModel UserVM { get; set; }

        public IActionResult Index([FromServices] IGetUserCommand getUserCommand) => getUserCommand?.Execute(this);

        [HttpPost]
        public IActionResult OnSubmit([FromServices] IAddUserCommand addUserCommand) => addUserCommand.Execute(this);
        
    }
}