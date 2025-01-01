using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.Interfaces
{
    internal interface ICommand
    {
        void Execute(string cmdLine);
        public string GetName();
        public string GetHelp();
    }
}
