using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork10.Interfaces;

namespace HomeWork10.Classes
{
    internal class CommandCommon
    {
        protected CommandList cmdList;
        public CommandCommon(CommandList commandList) 
        {
            cmdList = commandList;
        }
    }
}
