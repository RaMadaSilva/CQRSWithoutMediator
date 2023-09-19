using CQRWithoutMediator.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CQRWithoutMediator.Repositories
{
    public class CustomerReadRepository : ICustomerReadRepository
    {
        private readonly List<Customer> _customers;

        public CustomerReadRepository()
            {
                _customers = new List<Customer>(){
                new Customer("Pedro Portas", "pp@gmail.com"),
                new Customer("Andre rosario", "alp@gmail.com"),
                new Customer("Maurilson Kiffen", "mfk@gmail.com"),
                new Customer("Marta Lopes", "ml@gmail.com"),
                new Customer("Antonio Baltazar", "ab@gmail.com"),
            }; 
        }

        public async Task<IEnumerable<Customer>> GetAllCustomerAsync()
        {
            await Task.CompletedTask;
            return _customers; 
        }

        public async Task<Customer> GetCustomerByEmailAsync(string email)
        {
            var customer = _customers.FirstOrDefault(x => x.Email == email);
            await Task.CompletedTask;
            return customer; 

        }

        public async Task<Customer> GetCustomerByIdAsync(Guid id)
        {
            var customer = _customers.FirstOrDefault(x => x.Id == id);
            await Task.CompletedTask;
            return customer;

        }
    }
}
