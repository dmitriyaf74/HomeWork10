using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork10.Interfaces;

namespace HomeWork10.Classes
{
    internal class CommandEcho : CommandCommon, ICommand
    {
        public CommandEcho(CommandList commandList) : base(commandList){}

        public void Execute(string cmdLine)
        {
            if (cmdLine.Length > 1)
                Console.WriteLine(cmdLine.Substring(6, cmdLine.Length - 6));
            else
                Console.WriteLine("");
        }

        public string GetName()
        {
            return "/echo";
        }

        public string GetHelp()
        {
            return $"{this.GetName()} - повторялка";
        }
    }
}
