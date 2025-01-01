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
                Console.WriteLine($"{this.cmdList.userName}, добро пожаловать");
            }
            else
                DeleteUserCommands();
        }
        public void DeleteUserCommands()
        {
            for (int i = this.cmdList.Count - 1; i >= 0 ; i--)
            {
                if (this.cmdList[i].GetName() == "/echo")
                {
                    this.cmdList.RemoveAt(i);
                    break;
                }
                if (this.cmdList[i].GetName() == "/addtask")
                {
                    this.cmdList.RemoveAt(i);
                    break;
                }
                if (this.cmdList[i].GetName() == "/showtasks")
                {
                    this.cmdList.RemoveAt(i);
                    break;
                }
                if (this.cmdList[i].GetName() == "/removetask")
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
