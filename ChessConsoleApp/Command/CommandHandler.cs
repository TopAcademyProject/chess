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
        public CommandHandler(CommandList cmdList)
        {
            this.cmdList = cmdList;
        }
        #endregion
        #region methods & handlers
        private void ExtractArgs(string[] cmdSplited, string cmd)
        {
            bool commandFound = false;
            try
            {
                foreach (var item in cmdList.CommandArg)
                {
                    if (cmdSplited[1] == item.Split(' ')[0])
                    {
                        commandFound = true;
                        string tmp = item.Split(' ')[0];
                        string argument = tmp.Split(':')[1];
                        CommandLaunch commandLaunch = new CommandLaunch();
                        commandLaunch.ExecuteFn(argument);
                        break;
                    }
                }
                if(!commandFound) Console.WriteLine($"Error: Command {cmd} undefined.");
            }
            catch (Exception)
            {
                Console.WriteLine($"Error: {cmd} has not arguments. Please see #help.");
            }
        }
        public void Handle(string cmd)
        {
            bool commandFound = false;
            string[] cmdSplited = cmd.Split(' ');
            foreach (var item in cmdList.Command)
            {   foreach (var arg in cmdList.DefaultCommand)
                {
                    if (cmdSplited[0] == arg)
                    {
                        CommandLaunch commandLaunch = new CommandLaunch();
                        commandLaunch.ExecuteFn(arg);
                        commandFound = true;
                        break;
                    }
                }
                if (commandFound) break;
                if (cmdSplited[0] == item)
                {
                    commandFound = true;
                    ExtractArgs(cmdSplited, cmd);
                    break;
                }
            }
            if (!commandFound)
            {
                Console.WriteLine($"Error: Command {cmd} undefined.");
            }
        }
        #endregion
    }
}
