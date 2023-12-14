﻿using ChessConsoleApp.Command;
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
            CommandHandler cmdHamdler = new CommandHandler();
            Console.WriteLine($"{CommandHandler.APP_NAME} ({CommandHandler.VERSION}) started!");
            while (true)
            {
                Console.Write("#");
                cmdHamdler.Handle(Console.ReadLine());
            }
        }
    }
}
