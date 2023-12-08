using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChessConsoleApp.Command
{
    public class CommandHandler
    {
        #region import command lists
        private const string APP_NAME = "Application Testing Console";
        private const string VERSION = "VER 0.0.1 APLHA";
        public string GetAppName() => APP_NAME;
        public string GetAppVersion() => VERSION;
        CommandList cmdList = new CommandList();
        public CommandHandler() => cmdList = new CommandList();
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
                            Console.WriteLine($"Warning: {cmd} has not arguments or callback with error. Please see #help.");
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
