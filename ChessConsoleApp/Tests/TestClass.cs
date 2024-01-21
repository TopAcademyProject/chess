using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsoleApp.Tests
{
    public class TestClass
    {
        public void Run()
        {
            Random random = new Random();
            int temp1 = random.Next();
            int temp2 = random.Next();
            for (int i = 0; i < 1000000; i++)
            {
                Console.WriteLine($"{temp1, 15} | {temp2, 15}");
                temp1 = random.Next();
                temp2 = random.Next();
            }
        }
    }
}
