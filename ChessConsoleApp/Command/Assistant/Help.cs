using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsoleApp.Command.Assistant
{
    public  class Help
    {
        public Help() { }
        CommandList list = new CommandList();

        public void ShowHelp()
        {
            Console.WriteLine("\t\t" + "Help list");
            string tmp = null;
            foreach (var command in list.CommandArg)
            {
                if (tmp != command.Split(':')[0])
                {
                    Console.WriteLine("Command "+command.Split(':')[0]);
                    tmp = command.Split(':')[0];
                    foreach (var arguments in list.CommandArg)
                    {
                        if (tmp == arguments.Split(':')[0]) Console.WriteLine("\t"+arguments.Split(' ')[0] + "\t\t=> " + arguments.Split(' ')[1]);
                    }
                }
            }
            Console.WriteLine("Help list closed");
        }
    }
}
