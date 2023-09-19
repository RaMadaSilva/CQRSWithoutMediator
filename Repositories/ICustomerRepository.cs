using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRWithoutMediator.Domain;

namespace CQRWithoutMediator.Repositories
{
    public interface ICustomerRepository
    {
        Task CreateCustomerAsync(Customer customer);
        Task UdateCustomerAsync(Guid Id);
        Task DeleteCustomerAsync(Guid Id);
    }
}