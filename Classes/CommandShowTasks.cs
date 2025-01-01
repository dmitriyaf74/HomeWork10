using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork10.Interfaces;

namespace HomeWork10.Classes
{
    internal class CommandShowTasks : CommandCommon, ICommand
    {
        public CommandShowTasks(CommandList commandList) : base(commandList) { }

        public void Execute(string cmdLine)
        {
            if (this.cmdList.TaskList.Count == 0)
                Console.WriteLine($"{this.cmdList.userName}. Нет ни одной задачи");
            else
            for (int i = 0; i < this.cmdList.TaskList.Count; i++)
            {
                Console.WriteLine($"{i}-{this.cmdList.TaskList[i]} ");
            }
        }

        public string GetName()
        {
            return "/showtasks";
        }

        public string GetHelp()
        {
            return $"{this.GetName()} - показать задачи";
        }
    }
}
