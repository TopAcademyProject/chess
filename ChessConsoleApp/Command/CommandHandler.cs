using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsoleApp.Command
{
    public class CommandHandler
    {
        #region import command lists
        CommandList cmdList = new CommandList();
        public CommandHandler()
        {
            this.cmdList = new CommandList();
        }
        #endregion
        #region methods & handlers
        public void Handle(string cmd)
        {
            bool commandFound = false;
            if (cmd != "")
            {
                string[] cmdSplited = cmd.Split(' ');
                foreach (var item in cmdList.Command)
                {
                    foreach (var defaultCommand in cmdList.DefaultCommand)
                    {
                        if (cmdSplited[0] == defaultCommand)
                        {
                            CommandLaunch commandLaunch = new CommandLaunch();
                            commandLaunch.Run(defaultCommand);
                            commandFound = true;
                            break;
                        }
                    }
                    if (commandFound) break;
                    if (cmdSplited[0] == item)
                    {
                        commandFound = true;
                        bool argumentFound = false;
                        try
                        {
                            foreach (var commandArg in cmdList.CommandArg)
                            {
                                if (cmdSplited[1] == commandArg.Split(' ')[0])
                                {
                                    argumentFound = true;
                                    string tmp = commandArg.Split(' ')[0];
                                    string argument = tmp.Split(':')[1];
                                    CommandLaunch commandLaunch = new CommandLaunch();
                                    commandLaunch.Run(argument);
                                    break;
                                }
                            }
                            if (!argumentFound) Console.WriteLine($"Error: Command {cmd} undefined.");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"Warning: {cmd} has not arguments. Please see #help.");
                        }
                        break;
                    }
                }
                if (!commandFound)
                {
                    Console.WriteLine($"Error: Command {cmd} undefined.");
                }
            }
        }
        #endregion
    }
}
