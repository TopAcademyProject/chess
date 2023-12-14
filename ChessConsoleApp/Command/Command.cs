using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace ChessConsoleApp.Command
{
    public class Command
    {
        public const string PATH = "commands.json";
        public const string VERSION = "1.0";

        private Dictionary<string, List<string>> _commands;
        public string CommandVersion { get; set; }
        public Dictionary<string, List<string>> Commands { get => _commands; set => _commands = value; }

        public Command()
        {
            CommandVersion = VERSION;
            Commands = new Dictionary<string, List<string>>();
        }
    }
}
