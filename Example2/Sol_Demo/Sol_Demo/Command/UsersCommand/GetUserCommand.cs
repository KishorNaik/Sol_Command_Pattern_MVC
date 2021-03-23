using Microsoft.AspNetCore.Mvc;
using Sol_Demo.Controllers;
using Sol_Demo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Command.UsersCommand
{
    public interface IGetUserCommand : ICommand<UsersController>
    {

    }

    public class GetUserCommand : IGetUserCommand
    {
        private readonly IGetUserRepository getUserRepository = null;

        public GetUserCommand(IGetUserRepository getUserRepository)
        {
            this.getUserRepository = getUserRepository;
        }

        IActionResult ICommand<UsersController>.Execute(UsersController controller)
        {
            try
            {
                controller.UserVM.Users = getUserRepository.GetUserData();
                return controller.View(controller.UserVM);
            }
            catch
            {
                throw;
            }
        }
    }
}
