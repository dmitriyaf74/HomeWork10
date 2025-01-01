using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork10.Interfaces;

namespace HomeWork10.Classes
{
    internal class CommandStart : CommandCommon, ICommand
    {
        public CommandStart(CommandList commandList) : base(commandList) { }
        public void Execute(string cmdLine)
        {
            string oldUserName = this.cmdList.userName;
            this.cmdList.userName = "";
            while (this.cmdList.userName == "")
            {
                Console.WriteLine("Введите свое имя:");
                this.cmdList.userName = Console.ReadLine();
                if (this.cmdList.userName == "")
                    Console.WriteLine("Имя не может быть пустым");
            };
            if (this.cmdList.userName != "")
            {
                if (oldUserName == "")
                {
                    this.cmdList.Add(new CommandEcho(this.cmdList));
                    this.cmdList.Add(new CommandShowTasks(this.cmdList));
                    this.cmdList.Add(new CommandAddTask(this.cmdList));
                    this.cmdList.Add(new CommandRemoveTask(this.cmdList));
                }
                Console.WriteLine($"Привет, {this.cmdList.userName}, чем могу помочь?");
            }
            else
            {
                DeleteUserCommand("/echo");
                DeleteUserCommand("/addtask");
                DeleteUserCommand("/showtasks");
                DeleteUserCommand("/removetask");
            }
        }
        public void DeleteUserCommand(string cmdName)
        {
            for (int i = this.cmdList.Count - 1; i >= 0; i--)
            {
                if (this.cmdList[i].GetName() == cmdName)
                {
                    this.cmdList.RemoveAt(i);
                    break;
                }
            }
        }

        public string GetName()
        {
            return "/start";
        }

        public string GetHelp()
        {
            return $"{this.GetName()} - знакомство";
        }
    }
}
