using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsoleApp.Command
{
    public class CommandList
    {
        private List<string> _command = new List<string>()
        {
            "help",
            "test",
        };
        private List<string> _commandArg = new List<string>()
        {
            "help:"+" "+"View help list",
            "clear:"+" "+"Clear console",
            "test:FigureTest" + " " + "Test",
        };
        private List<string> _defaultCommand = new List<string>()
        {
            "help", "clear", "exit"
        };
        #region Constructor, getters;
        public CommandList()
        {
            Command = _command;
            CommandArg = _commandArg;
            DefaultCommand = _defaultCommand;
        }

        public List<string> Command { get => _command; set => _command = value; }
        public List<string> CommandArg { get => _commandArg; set => _commandArg = value; }
        public List<string> DefaultCommand { get => _defaultCommand; set => _defaultCommand = value; }
        #endregion
    }
}
