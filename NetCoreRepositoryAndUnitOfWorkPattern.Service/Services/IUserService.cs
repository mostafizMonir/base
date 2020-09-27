using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Services
{
    public interface IUserService
    {
        List<UserInfo> GetAllUsers();
        Task<UserInfo> UpdateUser(UserInfo newCustomer);
        Task<UserInfo> AddUser(UserInfo newCustomer);
    }
}