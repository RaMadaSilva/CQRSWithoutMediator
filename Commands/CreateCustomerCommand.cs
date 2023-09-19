using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRWithoutMediator.Commands.Interfaces;

namespace CQRWithoutMediator.Commands
{
    public sealed record CreateCustomerCommand(string Name,
                String Email) : ICommand;
}