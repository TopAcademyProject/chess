namespace ChessClassLibrary.ChessField
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
        Player player;

        public Figure(Player player, int value)
        {
            this.value = value;
            this.player = player;
        }

        public int Value { get => value; set => this.value = value; }
        public Player Player { get => player; set => player = value; }

    }
}