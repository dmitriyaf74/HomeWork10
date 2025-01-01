using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HomeWork10.Interfaces;

namespace HomeWork10.Classes
{
    internal class CommandList : List<ICommand>
    {
        public string userName = "";
        public List<string> TaskList  = new List<string>();

        public ICommand? FindCommand(string cmdName)
        {
            for (var i = 0; i < this.Count; i++)
                if (this[i].GetName() == cmdName)
                    return this[i];
            return null;
        }
    }

}
