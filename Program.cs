using HomeWork10.Interfaces;
using HomeWork10.Classes;
using System.Collections.Generic;

namespace HomeWork10
{

    internal class Program
    {
        private static CommandList commandList = new CommandList();



        static void ShowSelect()
        {
            Console.Write($"Выберите меню: ");
            foreach (ICommand cmd in GetCommandList())
            {
                Console.Write($"{cmd.GetName()} ");
            }
            Console.WriteLine("");
        }

        static void ShowWelcome()
        {
            Console.WriteLine("Добро пожаловать");
        }

        static void FakeSelect()
        {
            if (GetCommandList().userName == "")
                Console.WriteLine("Вы ошиблись при наборе команды.");
            else
                Console.WriteLine($"{GetCommandList().userName}, вы ошиблись при наборе команды.");
        }

        static void ExecuteCommand(string cmdLine)
        {
            var userCommandArr = cmdLine.Split(' ');
            ICommand? cmd = GetCommandList().FindCommand(userCommandArr[0]);
            if (cmd == null)
            {
                FakeSelect();
                ExecuteCommand("/help");
            }
            else
                cmd.Execute(cmdLine);
        }

        static void WaitReadLine()
        {
            string userCommand = "";
            string[] userCommandArr = { };

            do
            {
                ShowSelect();

                ExecuteCommand(Console.ReadLine());
            } while (true);

        }

        public static CommandList GetCommandList()
        {
            return commandList;
        }

        public static void InitCommandList(CommandList commandList)
        {
            commandList.Add(new CommandStart(commandList));
            commandList.Add(new CommandHelp(commandList));
            commandList.Add(new CommandInfo(commandList));
            //commandList.Add(new CommandEcho(commandList));
            commandList.Add(new CommandExit(commandList));
        }

        static void Main(string[] args)
        {
            InitCommandList(GetCommandList());

            ShowWelcome();
            WaitReadLine();
        }


    }
}
