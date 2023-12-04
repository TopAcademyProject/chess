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
        private void getArgs(string[] cmdSplited, string cmd)
        {
            bool commandFound = false;
            try
            {
/*                for (int i = 0; i < cmdList.CommandArg.Count; i++)
                {
                    string arg = cmdList.CommandArg.ToString().Split(' ')[0];
                    Console.WriteLine(arg[0]);
                }*/
                foreach (var item in cmdList.CommandArg)
                {
                    if (cmdSplited[1] == item)
                    {
                        string tmp = item;
                        string arg = tmp.Split(' ')[0];
                        arg = arg.Split(':')[1];
                        CommandLaunch commandLaunch = new CommandLaunch();
                        commandFound = true;
                        commandLaunch.ExecuteFn(arg);
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
            {
                if (cmdSplited[0] == "exit") Process.GetCurrentProcess().Kill();
                if (cmdSplited[0] == "help")
                {
                    CommandLaunch commandLaunch = new CommandLaunch();
                    commandLaunch.ExecuteFn(item);
                    commandFound = true;
                    break;
                }
                else if (cmdSplited[0] == item)
                {
                    commandFound = true;
                    getArgs(cmdSplited, cmd);
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
