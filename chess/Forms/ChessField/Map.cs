using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chess.Forms;

namespace chess.Forms.ChessField
{
    public class Map
    {
        Figure[,] figures;

        public Map()
        {
            this.Figures = new Figure[8,8]
            {
                { new Figure(Player.White,5),new Figure(Player.White,4),new Figure(Player.White,3),new Figure(Player.White,2),new Figure(Player.White,1),new Figure(Player.White,3),new Figure(Player.White,4),new Figure(Player.White,5) },
                { new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6) },
                { new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0) },
                { new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0) },
                { new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0) },
                { new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0) },
                { new Figure(Player.Black,5),new Figure(Player.Black,4),new Figure(Player.Black,3),new Figure(Player.Black,2),new Figure(Player.Black,1),new Figure(Player.Black,3),new Figure(Player.Black,4),new Figure(Player.Black,5) },
                { new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6) },
            };

        }

        public Figure GetCell(Position figurePosition)
        {
            return Figures[figurePosition.X, figurePosition.Y];
        }

        public Figure[,] Figures { get => figures; set => figures = value; }
    }
}
