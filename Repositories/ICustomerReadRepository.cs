using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRWithoutMediator.Domain;

namespace CQRWithoutMediator.Repositories
{
    public interface ICustomerReadRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomerAsync();
        Task<Customer> GetCustomerByIdAsync(Guid id);
        Task<Customer> GetCustomerByEmailAsync(string email);
    }
}