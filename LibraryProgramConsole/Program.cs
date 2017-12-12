using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgramConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMenu _consoleMenu = new ConsoleMenu();
            _consoleMenu.StartMenu();
            Console.ReadKey();
        }
    }
}
