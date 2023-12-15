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
        public const string APP_NAME = "Application Testing Console";
        public const string VERSION = "VER 0.0.2 APLHA";
        CommandList cmdList = new CommandList();
        public CommandHandler() => cmdList = new CommandList();


        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        private Command Initializate()
        {
            Command command = new Command();
            command.Commands.Add("help", new List<string> { null, "default" });
            command.Commands.Add("clear", new List<string> { null, "default" });
            command.Commands.Add("exit", new List<string> { null, "default" });
            command.Commands.Add("cmd", new List<string> { "default", "register", "append", "renove", "delete" });

            Save(command);
            return command;
        }
        public void Register(string command)
        {
            var tmp = Load();
            if (!tmp.Commands.ContainsKey(command))
            {
                tmp.Commands.Add(command, new List<string> { });
                Console.WriteLine($"Command \"{command}\" registered. Add arguments to work with this command using the method \"cmd:append\".");
            }
            else Console.WriteLine($"Command \"{command}\" already exists.");
            Save(tmp);
        }
        public void Append(string command, string argument)
        {
            var tmp = Load();
            List<string> arguments = new List<string>();
            bool commandFound = false;
            foreach (var i in tmp.Commands)
            {
                if (command == i.Key)
                {
                    commandFound = true;
                    if (!i.Value.Contains(argument))
                    {
                        if(i.Value.Contains("default"))
                        {
                            Console.WriteLine("Action not allowed.");
                            break;
                        }
                        foreach (var j in i.Value)
                        {
                            arguments.Add(j);
                        }
                        Console.WriteLine($"Argument \"{argument}\" for command \"{command}\" added successfuly.");
                        arguments.Add(argument);
                        tmp.Commands.Remove(command);
                        tmp.Commands.Add(command, arguments);
                        Save(tmp);
                        break;
                    }
                    else Console.WriteLine($"This argument already exists.");
                }
            }
            if (!commandFound) Console.WriteLine($"Command {command} not found.");
        }
        public void Addition()
        {
            Console.Write("Add to ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string command = Console.ReadLine();
            Console.ResetColor();
            Console.Write("Append: ");
            string argument = Console.ReadLine();
            Append(command, argument);
        }
        public void Registration()
        {
            Console.Write("Enter a name for the new command: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string command = Console.ReadLine();
            Console.ResetColor();
            Register(command);
        }
        public void Save(Command cmd) => File.WriteAllText(Command.PATH, JsonSerializer.Serialize(cmd, options));
        public Command Load() => File.Exists(Command.PATH) ? JsonSerializer.Deserialize<Command>(File.ReadAllText(Command.PATH)) : Initializate();

        public void Handle(string userInput)
        {
            var JSONFile = Load();
            CommandLaunch commandLaunch = new CommandLaunch();
            bool commandFound = false;
            if (userInput != "")
            {
                string[] userInputSplited = userInput.Split(':');
                if (JSONFile.Commands.ContainsKey(userInputSplited[0]))
                {
                    commandFound = true;
                    if (JSONFile.Commands[userInputSplited[0]].Contains(null))
                    {
                        commandLaunch.Launch(userInput);
                    } 
                    else
                    {
                        try
                        {
                            if (userInputSplited[1] != null)
                                if (JSONFile.Commands[userInputSplited[0]].Contains(userInputSplited[1])) commandLaunch.Launch(userInput);
                        } 
                        catch (Exception)
                        {
                            Console.WriteLine($"Error excepted. Command {userInput} has not arguments.");
                        }
                    }
                }
                if (!commandFound) Console.WriteLine($"Error: Command {userInput} undefined.");
            }
        }
    }
}
