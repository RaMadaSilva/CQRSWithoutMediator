using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRWithoutMediator.Commands.Interfaces;

namespace CQRWithoutMediator.Commands
{
    public sealed class CreateCustomerCommandResult : ICommandResult
    {
        public CreateCustomerCommandResult(string mensage)
        {
            Sucess = false;
            Mensage = mensage;
        }

        public CreateCustomerCommandResult(Guid id,
                string name,
                string email,
                DateTime date)
        {
            Id = id;
            Name = name;
            Email = email;
            Date = date;
            Sucess = true;

        }

        Guid Id { get; set; }
        string? Name { get; set; }
        string? Email { get; set; }
        DateTime? Date { get; set; }
        bool Sucess { get; set; }
        string? Mensage { get; set; }
    }
}