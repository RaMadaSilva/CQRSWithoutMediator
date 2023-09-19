using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRWithoutMediator.Domain
{
    public sealed class Customer
    {
        public Customer(string name, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}