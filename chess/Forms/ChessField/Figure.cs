namespace chess.Forms.ChessField
{

    public enum Player
    {
        Empty,
        Black,
        White
    }

    public enum FigureType
    {
        Empty,
        Pawn,
        King,
        Horse,        
    }

    public class Figure
    {
        int value;
        //FigureType type;
        Player player;

        public Figure(Player player, int value)
        {
            this.value = value;
            this.player = player;
        }


        public int Value { get => value; set => this.value = value; }
        //public FigureType Value { get => value; set => this.value = value; }
        public Player Player { get => player; set => player = value; }

        //public bool IsEmpty { get => Value == FigureType.Empty; }

    }
}