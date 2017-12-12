using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgramConsole.Domain
{
    interface IState
    {
        void Open();

        void Close();
    }
}
