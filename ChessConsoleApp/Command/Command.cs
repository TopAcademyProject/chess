﻿using System.Collections.Generic;


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
    public class OldCommand
    {
        public const string VERSION = "1.0";
        private Dictionary<string, List<string>> _commands;
        public string CommandVersion { get; set; }
        public Dictionary<string, List<string>> Commands { get => _commands; set => _commands = value; }
        public OldCommand()
        {
            CommandVersion = VERSION;
            Commands = new Dictionary<string, List<string>>();
        }
    }
}
