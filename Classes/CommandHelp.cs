using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork10.Interfaces;

namespace HomeWork10.Classes
{
    internal class CommandHelp: CommandCommon, ICommand
    {
        public CommandHelp(CommandList commandList) : base(commandList) { }
        public void Execute(string cmdLine)
        {
            foreach (ICommand cmd in this.cmdList)
            {
                Console.WriteLine($"{cmd.GetHelp()} ");
            }
        }

        public string GetName()
        {
            return "/help";
        }

        public string GetHelp()
        {
            return $"{this.GetName()} - текущее сообщение";
        }
}
}
