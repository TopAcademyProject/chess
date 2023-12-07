using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessClassLibrary
{
    enum Piece
    {WPAWN,BPAWN,WROOK,BROOK,WBISHOP,BBISHOP,WKNIGHT,BKNIGHT,WQUEEN,BQUEEN,WKING,BKING,NONE }
    enum Castle
    {WSHORT,BSHORT,WLONG,BLONG, NONE }
    enum Promotion
    {WKNIGHT,BKNIGHT,WBISHOP,BBISHOP,WROOK,BROOK,WQUEEN,BQUENN,NONE }

    public int X1;




    public abstract class Figure
    {
        private int _id;
        private string _name;
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public Figure(int id)
        {
            Id = id;
        }
    }
    public class Pawn : Figure
    {
        public Pawn(int id) : base(id)
        {

        }
    }
}
