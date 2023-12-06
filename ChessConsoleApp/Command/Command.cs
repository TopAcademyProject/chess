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
        public const string PATH = "../../command/commands.json";

        private List<string> _commands;
        private List<string> _arguments;        

        public List<string> Commands { get => _commands; set => _commands = value; }
        public List<string> Arguments { get => _arguments; set => _arguments = value; }

        public Command() { 
            Commands = new List<string>();
            Arguments = new List<string>();
        }
        public Command(string commands = "NULL", string arguments = "NULL")
        {
            //if (commands == null) commands = "NULL"; if (arguments==null) arguments = "NULL";

            Commands.Add(commands);
            Arguments.Add(arguments);
        }
        public void Test()
        {
            Run();
            Show();
            AppendCommand("TestCommands");
            Show();
        }
        public void AppendCommand(string command)
        {
            if(JsonConvert.DeserializeObject<Command>(File.ReadAllText(PATH))  != null)
            {
                var cmd = File.ReadAllText(PATH);
                Commands.Add(command);
            }
        }
        private Command InitializeLists()
        {
            Commands.Add(" ");
            Arguments.Add(" ");
            return this;
        }
        public void Run()
        {
            var cmd = File.Exists(PATH) ? JsonConvert.DeserializeObject<Command>(File.ReadAllText(PATH)) : InitializeLists();
            try
            {
                var tmp = JsonConvert.DeserializeObject<Command>(File.ReadAllText(PATH));
                Console.WriteLine("Output command");
            }
            catch { }
            File.WriteAllText(PATH, JsonConvert.SerializeObject(cmd));
        }
        #region load & save
        private Command Load() => File.Exists(PATH) ? JsonConvert.DeserializeObject<Command>(File.ReadAllText(PATH)) : InitializeLists();
        private void Save(Command cmd) => File.WriteAllText(PATH, JsonConvert.SerializeObject(cmd));
        #endregion
        public void Show()
        {
            if(Commands == null || Arguments == null)
            {
                Console.WriteLine($"Fatal error: Failed to load data from configuration file ({PATH}).");
                return;
            }
            Console.WriteLine(Commands.Count);
            foreach (var item in Commands)
            {
                Console.WriteLine(item);
            }
            foreach (var arg in Arguments)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
