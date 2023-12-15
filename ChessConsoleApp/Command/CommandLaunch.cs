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
            #region Declaring Class Instances
            Help help = new Help();
            CommandHandler handler = new CommandHandler();
            #endregion
            switch (item)
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
                case "cmd:append":
                    handler.Addition();
                    break;
                case "cmd:register":
                    handler.Registration();
                    break;
                #endregion

                default:
                    Console.WriteLine($"The function call method for {item} undefined.");
                    break;
            }
        }
    }
}