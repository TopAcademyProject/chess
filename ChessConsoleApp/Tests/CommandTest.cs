using ChessConsoleApp.Command;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace ChessConsoleApp.Tests
{
    public class CommandTest
    {
        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        private Command.Command Initializate()
        {
            Command.Command command = new Command.Command();
            command.Commands.Add("run", new List<string> { "test", "test24"});
            command.Commands.Add("runDev", new List<string> { "testerhre" });
            Save(command);
            return command;
        }
        public void Register(string command)
        {
            var tmp = Load();
            if (!tmp.Commands.ContainsKey(command)) tmp.Commands.Add(command, new List<string> { });
            else Console.WriteLine($"Command \"{command}\" already exists.");
        }
        public void Append(string command, string argument) {
            var tmp = Load();
            List<string> arguments = new List<string>();
            bool commandFound = false;
            foreach(var i in tmp.Commands)
            {
                if(command == i.Key)
                {
                    commandFound = true;
                    if (!i.Value.Contains(argument))
                    {
                        foreach(var j in i.Value)
                        {
                            arguments.Add(j);
                        }
                        Console.WriteLine($"Argument \"{argument}\" for command \"{command}\" added successfuly");
                        arguments.Add(argument);
                        tmp.Commands.Remove(command);
                        tmp.Commands.Add(command, arguments);
                        Save(tmp);
                        break;
                    }
                    else Console.WriteLine($"This argument already exists.");
                } 
            }
            if (!commandFound) Console.WriteLine($"Command {command} not found");
        }
        public void Save(Command.Command cmd) => File.WriteAllText(Command.Command.PATH, JsonSerializer.Serialize(cmd, options));
        public Command.Command Load() => File.Exists(Command.Command.PATH) ? JsonSerializer.Deserialize<Command.Command>(File.ReadAllText(Command.Command.PATH)) : Initializate();
    }
}
