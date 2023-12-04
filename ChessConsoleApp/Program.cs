using ChessConsoleApp.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommandList cmdList = new CommandList();
            var cmdHamdler = new Command.CommandHandler(cmdList);
            Console.WriteLine("Console application started!");
            while (true)
            {
                Console.Write("#");
                cmdHamdler.Handle(Console.ReadLine());
            }
        }
    }
}
