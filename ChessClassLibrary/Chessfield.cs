using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessClassLibrary
{
    public class Chessfield
    {
        const int rowsnumbers = 8;
        const int columnsletters = 8;
        int[,] chessfield = new int[rowsnumbers, columnsletters]

            {
                {1,2,3,4,5,3,2,1},
                {6,6,6,6,6,6,6,6},
                {0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0},
                {6,6,6,6,6,6,6,6},
                {5,4,3,2,1,3,4,5},

            };

           

    }
}
