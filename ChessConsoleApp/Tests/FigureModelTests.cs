using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessConsoleApp.Command;
using Newtonsoft.Json;

namespace ChessConsoleApp.Tests
{
    public class FigureModelTests
    {
        public void RunTest ()
        {
            Command.Command cmd = new Command.Command();
            cmd.Test();

        }
    }
}
