using ChessConsoleApp.Command.Assistant;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ChessConsoleApp.Command
{
    public class CommandLaunch
    {
        public void Launch(string item)
        {
            #region Validation
            bool hasArgument = false;
            var command = item.Split(' ')[0];
            string argument = null;
            try
            {
                if (item.Split(' ')[1] != "")
                {
                    argument = item.Split(' ')[1];
                    hasArgument = true;
                }
            }
            catch 
            {

            }
            #endregion
            #region Declaring Class Instances
            Help help = new Help();
            CommandHandler handler = new CommandHandler();
            #endregion
            switch (command)
            {

                /* 
                 * Для корректной работы консоли, пожалуйста, не удаляйте кейсы из региона Default
                 * Чтобы добавить новый метод вызова, используйте такой шаблон:
                 * 
                 * case "exampleCommand:exampleArgument"
                 *      //methods
                 *      break;
                 */

                #region Default
                case "exit":
                    Console.WriteLine("GoodBye");
                    Process.GetCurrentProcess().Kill();
                    break;                        
                case "clear":
                    Console.Clear();
                    break;
                case "help":
                    help.ShowHelp();
                    break;
                case "version":
                    Console.WriteLine($"Application version {CommandHandler.VERSION}, command version {Command.VERSION}.");
                    break;
                case "cmd:append":
                    if (hasArgument) handler.Append(argument);
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Example: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("cmd:register ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("otherCommand:otherArgument");
                        Console.ResetColor();
                    }
                    break;
                case "cmd:register":
                    if (hasArgument) handler.Register(argument);
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Example: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("cmd:append ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("newCommand");
                        Console.ResetColor();
                    }
                    break;
                #endregion

                default:
                    Console.Write($"The function call method for");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($" \"{item}\" ");
                    Console.ResetColor();
                    Console.WriteLine("undefined.");
                    break;
            }
        }
    }
}