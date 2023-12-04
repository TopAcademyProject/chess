using ChessConsoleApp.Tests;
using System;
using System.Collections.Generic;

namespace ChessConsoleApp.Command
{
    public class CommandLaunch
    {
        public void ExecuteFn(string item)
        {
            switch (item)
            {
                case "help":
                    Console.WriteLine("This is help.");
                    break;
                case "testFigureTest":
                    FigureModelTests launch = new FigureModelTests();
                    launch.GetFigureTest();
                    break;
            }
        }
    }
}