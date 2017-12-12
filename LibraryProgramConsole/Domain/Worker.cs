using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgramConsole.Domain
{
    public class Worker
    {
        public Library WorkPlace { get; set; }

        public string Name { get; set; }

        public Worker (string name, Library workplace)
        {
            Name = name;
            WorkPlace = workplace;
        }
    }
}
