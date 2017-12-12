using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgramConsole.Domain
{
    public class Table
    {
        public static void ShowHeader(string first, string second, string third)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine($"         {first}                 |    {second}     |   {third}   |");
            Console.WriteLine("---------------------------------------------------------------------------");
        }
    }
}
