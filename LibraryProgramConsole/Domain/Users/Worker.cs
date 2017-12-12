using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgramConsole.Domain.Users
{
    public class Worker : User
    {
        public Worker(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
    }
}
