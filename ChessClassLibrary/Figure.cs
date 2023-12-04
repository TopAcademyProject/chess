using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessClassLibrary
{
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
