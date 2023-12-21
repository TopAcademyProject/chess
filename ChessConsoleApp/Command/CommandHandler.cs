using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ChessConsoleApp.Command
{
    public class CommandHandler
    {
        public const string APP_NAME = "Application Testing Console";
        public const string VERSION = "1.1";
        public string[] DEFAULT_COMMANDS =
        {
            "help", "exit", "clear",
            "cmd:vertion",
            "cmd:register",
            "cmd:append",
            "cmd:remove",
            "cmd:delete",
            "cmd:convert",
        };
        public string[] CONVERTABLE_VERSIONS = { null };
        public string[] COMPATIBILITY = { "1.0", "1.1" };

        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        private Command Initializate()
        {
            Command command = new Command();
            command.CommandVersion = VERSION;
            return command;
        }
        public void Register(string command)
        {
            string cmd = command.Split(':')[0];
            var tmp = Load();
            if (!tmp.Commands.ContainsKey(command))
            {
                tmp.Commands.Add(command, new List<string> { });
                Console.Write($"Command ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\"{cmd}\"");
                Console.ResetColor();
                Console.Write($" registered. Add arguments to work with this command using the method ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\"cmd:append\"");
                Console.ResetColor();
                Console.WriteLine(".");
            }
            else
            {
                Console.Write($"Command ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\"{cmd}\"");
                Console.ResetColor();
                Console.WriteLine($" already exists.");
            }
            Save(tmp);
        }
        public void Append(string commandWithArgument)
        {
            Console.WriteLine("DDF");
            string command;
            string argument;
            if (commandWithArgument.Split(':')[1] != null)
            {
                if (commandWithArgument.Split(':')[1] == "built-in")
                {
                    Console.WriteLine("Action not allowed.");
                    return;
                }
                argument = commandWithArgument.Split(':')[1] == "null" ? null : commandWithArgument.Split(':')[1];
                command = commandWithArgument.Split(':')[0];
            }
            else return;
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
                        if (i.Value.Contains("built-in"))
                        {
                            Console.WriteLine("Action not allowed.");
                            break;
                        }
                        foreach (var j in i.Value)
                        {
                            arguments.Add(j);
                        }
                        Console.Write($"Argument ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\"{argument}\"");
                        Console.ResetColor();
                        Console.Write($" for command ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"\"{command}\"");
                        Console.ResetColor();
                        Console.WriteLine($" added successfuly.");
                        arguments.Add(argument);
                        tmp.Commands.Remove(command);
                        tmp.Commands.Add(command, arguments);
                        Save(tmp);
                        break;
                    }
                    else Console.WriteLine($"This argument already exists.");
                }
            }
            if (!commandFound)
            {
                Console.Write($"Command ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\"{command}\"");
                Console.ResetColor();
                Console.WriteLine($" not found.");
            }
        }
        public void Save(Command cmd) => File.WriteAllText(Command.PATH, JsonSerializer.Serialize(cmd, options));
        public Command Load() => File.Exists(Command.PATH) ? JsonSerializer.Deserialize<Command>(File.ReadAllText(Command.PATH)) : Initializate();
        public Command Convert(Command cmd)
        {
            Console.WriteLine("Comming soon...");
            return null;
        }
        private Command CheckCommandVersion(Command cmd)
        {
            var version = cmd.CommandVersion;
            string userInput;
            if (version == Command.VERSION) return cmd;
            else if(version != Command.VERSION)
            {
                for (int i = 0; i < COMPATIBILITY.Length; i++) if(version == COMPATIBILITY[i]) return cmd;
                for (int i = 0; i < CONVERTABLE_VERSIONS.Length; i++)
                {
                    if (version == CONVERTABLE_VERSIONS[i])
                    {
                        Console.Write("Conversion required. Enter \"yes\" (y) to convert: ");
                        userInput = Console.ReadLine();
                        if (userInput == "yes" || userInput == "y") {
                            Console.Write("#");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("cmd:convert");
                            Console.ResetColor();
                            return Convert(cmd);
                        };
                    }
                }
            }
            Console.Write("Continuing to work with custom commands is impossible!\nTo recreate, enter \"yes\" (y): ");
            userInput = Console.ReadLine();
            if(userInput == "yes" || userInput == "y")
            {
                Console.Write("The commands will be overwritten, are you sure? Entes \"yes\"(y) or \"no\": ");
                userInput = Console.ReadLine();
                if (userInput == "yes" || userInput == "y")
                {
                    Command initializatedCmd = Initializate();
                    Save(initializatedCmd);
                    return initializatedCmd;
                }
            }
            Console.WriteLine($"Continuing to work with the file is impossible.");
            return null;
        }

        public void Handle(string userInput)
        {
            if (userInput != "")
            {
                bool commandFound = false;
                CommandLauncher commandLauncher = new CommandLauncher();
                #region handling default commands
                {
                    bool found = false;
                    string cmd = userInput.Split(' ')[0];
                    for (int i = 0; i < DEFAULT_COMMANDS.Length - 1; i++)
                    {
                        if (cmd.Split(':')[0] == DEFAULT_COMMANDS[i].Split(':')[0])
                        {
                            if (cmd.Split(' ')[0] == DEFAULT_COMMANDS[i])
                            {
                                commandLauncher.Launch(userInput);
                                found = true;
                            }
                        }
                        if (found) return;
                    }
                }
                #endregion
                #region handling custom commands
                var JSONFile = Load();
                if (CheckCommandVersion(JSONFile) == null) return;
                string uisp = userInput.Split(' ')[0];
                string[] userInputSplited = uisp.Split(':');
                if (JSONFile.Commands.ContainsKey(userInputSplited[0]))
                {
                    commandFound = true;
                    if (JSONFile.Commands[userInputSplited[0]].Contains(null)) commandLauncher.Launch(userInput);
                    else
                    {
                        try
                        {
                            if (userInputSplited[1] != null)
                                if (JSONFile.Commands[userInputSplited[0]].Contains(userInputSplited[1])) commandLauncher.Launch(userInput);
                                else
                                {
                                    Console.Write($"Command argument ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write($"\"{userInput}\"");
                                    Console.ResetColor();
                                    Console.WriteLine($" not registered.");
                                }
                        }
                        catch (Exception)
                        {
                            Console.Write($"Command ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"\"{userInput}\"");
                            Console.ResetColor();
                            Console.WriteLine($" has not arguments.");
                        }
                    }
                }
                if (!commandFound)
                {
                    Console.Write($"Error: Command ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"\"{userInput}\"");
                    Console.ResetColor();
                    Console.WriteLine($" undefined.");
                }
                #endregion
            }
        }
    }
}
