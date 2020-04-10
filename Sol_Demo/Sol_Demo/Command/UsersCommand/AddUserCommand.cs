using Microsoft.AspNetCore.Mvc;
using Sol_Demo.Controllers;
using Sol_Demo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Command.UsersCommand
{
    public interface IAddUserCommand : ICommand<UsersController>
    {

    }

    public class AddUserCommand : IAddUserCommand
    {
        private readonly IAddUserRepository addUserRepository = null;

        public AddUserCommand(IAddUserRepository addUserRepository)
        {
            this.addUserRepository = addUserRepository;
        }

        IActionResult ICommand<UsersController>.Execute(UsersController controller)
        {
            try
            {
                String message =
                        (this.addUserRepository.AddUser(controller.UserVM.Users))
                        ? "Save"
                        : "Something wen wrong";

                controller.ViewBag.Message = message;

                return controller.View("Index", controller.UserVM);
            }
            catch
            {
                throw;
            }
            
        }
    }
}
