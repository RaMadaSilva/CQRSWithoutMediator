using CQRWithoutMediator.Domain;

namespace CQRWithoutMediator.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        List<Customer> customers = new List<Customer>();
        public  async Task CreateCustomerAsync(Customer customer)
        {
            await Task.CompletedTask; 
            customers.Add(customer);
        }

        public async  Task DeleteCustomerAsync(Guid id)
        {
            var customer = customers.FirstOrDefault(x => x.Id == id);
            await Task.CompletedTask;
            customers.Remove(customer); 
        }

        public async Task UdateCustomerAsync(Guid id)
        {
            var customer = customers.FirstOrDefault(x => x.Id == id);
            await Task.CompletedTask;
            customers.Remove(customer);
        }
    }
}
