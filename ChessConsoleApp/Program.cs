using ChessConsoleApp.Command;
using System;

namespace ChessConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommandHandler cmdHamdler = new CommandHandler();
            Console.Write($"{CommandHandler.APP_NAME} started! ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"App version {CommandHandler.VERSION}");
            Console.ResetColor();
            while (true)
            {
                Console.Write("#");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string userInput = Console.ReadLine();
                Console.ResetColor();
                cmdHamdler.Handle(userInput);
            }
        }
    }
}
