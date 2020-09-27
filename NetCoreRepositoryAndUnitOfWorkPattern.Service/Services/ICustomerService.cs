using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Services
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomer();
        Task<Customer> GetCustomerById(int id);
        Task<Customer> AddCustomer(Customer newCustomer);
        Customer Add(Customer newCustomer);
        Task<Customer> UpdateCustomer(Customer newCustomer);
    }
}