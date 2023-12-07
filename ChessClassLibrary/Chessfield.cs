using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessClassLibrary
{
    public class ChessField
    {
        const int rowsnumbers=8;
        const int colsletters=8;
        public int[,] map = new int[rowsnumbers, colsletters]     
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
