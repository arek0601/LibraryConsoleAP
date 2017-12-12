using LibraryProgramConsole.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgramConsole.Domain
{
    public class Order
    {
        public Customer BookReader { get; set; }

        public Book BookRent { get; set; }

        public bool Status { get; set; }

        public Order(Customer customer, Book book)
        {
            BookReader = customer;
            BookRent = book;
        }
    }
}
