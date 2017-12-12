using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgramConsole.Domain.Users
{
    public class Customer : User
    {
        public Customer(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
    }
}
