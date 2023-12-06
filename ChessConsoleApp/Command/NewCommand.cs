using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChessConsoleApp.Command
{
    public class cmdObject
    {
        public string _command { get; set; }
        public string _argument { get; set; }
        public Dictionary<string, cmdObject> _hasArgument { get; set; }
    }
    public class NewCommand
    {
        public const string PATH = "../../command/commands.json";

        public void Run()
        {
            string str = "gdsg";
            var cmdObject = new cmdObject()
            {
                _command = "Test",
                _hasArgument = new Dictionary<string, cmdObject>
                {
                    [str] = new cmdObject { _command = "Test", _argument = "test" }
                },
            };
            cmdObject._hasArgument.Add(str+"2", new cmdObject { _argument = "teat"});
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(cmdObject, options);
            Console.WriteLine(jsonString);
            File.WriteAllText(PATH, jsonString);
        }
    }
}
