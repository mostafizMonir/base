using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<UserInfo> _userRepository;

        public UserService(IRepository<UserInfo> userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserInfo> GetAllUsers()
        {
            return _userRepository.GetAll().ToList();
        }

        public async Task<UserInfo> GetCustomerById(int id)
        {
            return await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id.ToString());
            //return await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<UserInfo> AddUser(UserInfo newCustomer)
        {
            return await _userRepository.AddAsync(newCustomer);
        }

        public async Task<UserInfo> UpdateUser(UserInfo newCustomer)
        {
           return await  _userRepository.UpdateAsync(newCustomer);
        }
    }
}