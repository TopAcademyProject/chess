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
            "test"
        };
        private List<string> _commandArg = new List<string>()
        {
            "test:testFigureTest"// + " " + "description"
        };

        public CommandList()
        {
            Command = _command;
            CommandArg = _commandArg;
        }

        public List<string> Command { get => _command; set => _command = value; }
        public List<string> CommandArg { get => _commandArg; set => _commandArg = value; }
    }
}
