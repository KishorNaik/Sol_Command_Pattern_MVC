using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Repository
{
    public interface IGetUserRepository
    {
        UserModel GetUserData();
    }

    public class GetUserRepository : IGetUserRepository
    {
        UserModel IGetUserRepository.GetUserData()
        {
            try
            {
                return new UserModel()
                {
                    FirstName = "Kishor",
                    LastName = "Naik"
                };
            }
            catch
            {
                throw;
            }
        }
    }
}
