using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork10.Interfaces;

namespace HomeWork10.Classes
{
    internal class CommandAddTask : CommandCommon, ICommand
    {
        public CommandAddTask(CommandList commandList) : base(commandList) { }

        public void Execute(string cmdLine)
        {
            string taskName = "";
            while (taskName == "")
            {
                Console.WriteLine($"{this.cmdList.userName}. Введите описание задачи");
                taskName = Console.ReadLine();
            }
            this.cmdList.TaskList.Add(taskName);
            Console.WriteLine($"Задача {taskName} добавлена");
        }

        public string GetName()
        {
            return "/addtask";
        }

        public string GetHelp()
        {
            return $"{this.GetName()} - добавить задачу";
        }
    }
}
