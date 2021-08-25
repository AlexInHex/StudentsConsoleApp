using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsConsoleApp;

namespace StudentsConsoleApp.Commands
{
    class AddCommand: Command
    {
        public AddCommand(Repository repository, string[] parametrs) 
            : base(repository,parametrs)
        {

        }

       
    }
}
