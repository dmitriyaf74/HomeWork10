using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork10.Interfaces;

namespace HomeWork10.Classes
{
    internal class CommandInfo : CommandCommon, ICommand
    {
        public CommandInfo(CommandList commandList) : base(commandList) { }
        public void Execute(string cmdLine)
        {
            Console.WriteLine("Дата создания 01.01.2025");
            Console.WriteLine("Версия 1");
        }

        public string GetName()
        {
            return "/info";
        }

        public string GetHelp()
        {
            return $"{this.GetName()} - о программе";
        }
    }
}
