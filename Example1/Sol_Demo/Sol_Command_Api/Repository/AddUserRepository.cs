using Sol_Command_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Command_Api.Repository
{
    public interface IAddUserRepository
    {
        Task<bool> AddUsersAsync(UserModel userModel);
    }

    public class AddUserRepository : IAddUserRepository
    {
        Task<bool> IAddUserRepository.AddUsersAsync(UserModel userModel)
        {
            return Task.FromResult<Boolean>(true);
        }
    }
}