using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsoleApp.Command.Assistant
{
    public class Help
    {
        public void ShowHelp()
        {
            Console.WriteLine("Comming soon...");
        }

        public int Foo(int n)
        {
            if (n == 1) return 3;
            if (n > 1) return 2 * Foo(n - 1) - n + 1;
            return -999;
        }
    }
}
