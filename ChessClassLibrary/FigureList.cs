using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessClassLibrary
{
    public class FigureList
    {
        public string[,] list = new string[12, 2]
        {
            { "11", "white pawn"},
            { "12", ""},
            { "13", ""},
            { "14", ""},
            { "15", ""},
            { "16", ""},
            { "21", "black pawn"},
            { "22", ""},
            { "23", ""},
            { "24", ""},
            { "25", ""},
            { "26", ""},
        };
        private string[] ExtractString(string firstItem, string secondItem) => new string[2] { firstItem, secondItem };

        public string[] GetFigure(int id)
        {
            for (int i = 0; i < 26; i++)
            {
                if (i == 17) i = 21;
                if (list[i, 0] == id.ToString())
                {
                    return ExtractString(list[i,0], list[i,1]);
                }
            }

            return null;
        }
    }
}
