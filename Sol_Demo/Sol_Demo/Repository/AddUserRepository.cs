using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Repository
{
    public interface IAddUserRepository
    {
        bool AddUser(UserModel userModel);
    }
    public class AddUserRepository : IAddUserRepository
    {
        bool IAddUserRepository.AddUser(UserModel userModel)
        {
            try
            {
                // Add Code

                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
