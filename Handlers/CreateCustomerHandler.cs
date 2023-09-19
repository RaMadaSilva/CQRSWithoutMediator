using CQRWithoutMediator.Commands;
using CQRWithoutMediator.Domain;
using CQRWithoutMediator.Repositories;

namespace CQRWithoutMediator.Handlers
{
    public class CreateCustomerHandler : ICommandHander<CreateCustomerCommand, CreateCustomerCommandResult>
    {
        private readonly ICustomerRepository _writeCustomer;
        private readonly ICustomerReadRepository _readCustomer;

        public CreateCustomerHandler(ICustomerRepository writeCustomer,
            ICustomerReadRepository readCustomer)
        {
            _writeCustomer = writeCustomer;
            _readCustomer = readCustomer;
        }

        public async Task<CreateCustomerCommandResult> Handler(CreateCustomerCommand command)
        {
            //verificar se existe um cliente com o mesmo email 

            var customerEntity = await _readCustomer.GetCustomerByEmailAsync(command.Email);

            if (customerEntity != null)
                return new CreateCustomerCommandResult("ja existe um utilizador com esse email");

            //caso nao exita o cliente é criado um no banco de dados 
            var customer = new Customer(command.Name, command.Email);
            await _writeCustomer.CreateCustomerAsync(customer);

            return new CreateCustomerCommandResult(customer.Id, customer.Name, customer.Email, DateTime.Now);
        }
    }
}