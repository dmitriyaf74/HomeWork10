using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork10.Interfaces;

namespace HomeWork10.Classes
{
    internal class CommandExit : CommandCommon, ICommand
    {
        public CommandExit(CommandList commandList) : base(commandList) { }
        public void Execute(string cmdLine)
        {
            Environment.Exit(0);
        }

        public string GetName()
        {
            return "/exit";
        }

        public string GetHelp()
        {
            return $"{this.GetName()} - завершение программы";
        }
    }
}
