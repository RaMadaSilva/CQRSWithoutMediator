using CQRWithoutMediator.Queries;
using CQRWithoutMediator.Repositories;

namespace CQRWithoutMediator.Handlers
{
    public class CustomerQueryHandler : ICommandHander<CustomerQueryByEmail, CustomerQueryResult>
    {
        private readonly ICustomerReadRepository _readRepo;

        public CustomerQueryHandler(ICustomerReadRepository readRepo)
        {
            _readRepo = readRepo;
        }

        public async Task<CustomerQueryResult> Handler(CustomerQueryByEmail command)
        {
            var customer = await _readRepo.GetCustomerByEmailAsync(command.Email);

            return new CustomerQueryResult(customer.Id, customer.Name, customer.Email);
        }
    }
}