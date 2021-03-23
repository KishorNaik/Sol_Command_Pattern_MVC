using Sol_Command.Cores.Commands;
using Sol_Command_Api.Models;
using Sol_Command_Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Command_Api.Commands
{
    public interface IAddUserCommand : ICommand<UserModel, bool>
    {
    }

    public class AddUserCommand : IAddUserCommand
    {
        private readonly IAddUserRepository addUserRepository = null;

        public AddUserCommand(IAddUserRepository addUserRepository)
        {
            this.addUserRepository = addUserRepository;
        }

        async Task<bool> ICommand<UserModel, bool>.HandleAsync(UserModel request)
        {
            return await this.addUserRepository.AddUsersAsync(request);
        }
    }
}