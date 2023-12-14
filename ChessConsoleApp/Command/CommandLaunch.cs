using ChessConsoleApp.Command.Assistant;
using ChessConsoleApp.Tests;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ChessConsoleApp.Command
{
    public class CommandLaunch
    {
        public void Run(string item)
        {
            switch (item)
            {
                case "exit":
                    Process.GetCurrentProcess().Kill();
                    break;                        
                case "clear":
                    Console.Clear();
                    break;
                case "help":
                    Help help = new Help();
                    help.ShowHelp();
                    break;
                case "run":
                    CommandTest commandTest = new CommandTest();
                    break;
            }
        }
    }
}