using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork10.Interfaces;

namespace HomeWork10.Classes
{
    internal class CommandRemoveTask : CommandCommon, ICommand
    {
        public CommandRemoveTask(CommandList commandList) : base(commandList) { }

        public void Execute(string cmdLine)
        {
            if (this.cmdList.TaskList.Count == 0)
                Console.WriteLine("Нет ни одной задачи");
            else
            {
                ICommand? cmd = this.cmdList.FindCommand("/showtasks");
                Console.WriteLine("Выберите задачу для удаления:");
                cmd.Execute("");
                string s = Console.ReadLine();
                int i;
                if (int.TryParse(s, out i))
                {
                    if (i < this.cmdList.TaskList.Count)
                        this.cmdList.TaskList.RemoveAt(i);
                    else
                        Console.WriteLine("Указан неверный номер задачи");
                }
                else
                    Console.WriteLine("Ошибка ввода номера задачи");
            }
        }

        public string GetName()
        {
            return "/removetask";
        }

        public string GetHelp()
        {
            return $"{this.GetName()} - удалить задачу";
        }
    }
}
