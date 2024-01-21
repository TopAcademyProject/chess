namespace ChessClassLibrary.ChessField
{
    public class Map
    {
        Figure[,] figures;
        /// <summary>
        /// Игровая карта с правильным расположением фигур на полею
        /// </summary>
        public Map() => Figures = new Figure[8, 8]
        {
            { new Figure(Player.White,5),new Figure(Player.White,4),new Figure(Player.White,3),new Figure(Player.White,2),new Figure(Player.White,1),new Figure(Player.White,3),new Figure(Player.White,4),new Figure(Player.White,5) },
            { new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6) },
            { new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0) },
            { new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0) },
            { new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0) },
            { new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0) },
            { new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6) },
            { new Figure(Player.Black,5),new Figure(Player.Black,4),new Figure(Player.Black,3),new Figure(Player.Black,2),new Figure(Player.Black,1),new Figure(Player.Black,3),new Figure(Player.Black,4),new Figure(Player.Black,5) },
        };

        public Figure GetCell(Position figurePosition) => Figures[figurePosition.X, figurePosition.Y];

        public Figure[,] Figures { get => figures; set => figures = value; }

        //public void UpdateMap()
        /// <summary>
        /// Debug map. For editing.
        /// </summary>
        /// <param name="DebugMode"></param>
        public Map(bool DebugMode) => Figures = new Figure[8, 8]
        {
            { new Figure(Player.White,5),new Figure(Player.White,4),new Figure(Player.White,3),new Figure(Player.White,2),new Figure(Player.White,1),new Figure(Player.White,3),new Figure(Player.White,4),new Figure(Player.White,5) },
            { new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,2),new Figure(Player.Empty,0),new Figure(Player.White,6),new Figure(Player.White,6),new Figure(Player.White,6) },
            { new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Black,1),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0) },
            { new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0) },
            { new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0) },
            { new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0),new Figure(Player.Empty,0) },
            { new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Empty,0),new Figure(Player.Black,6),new Figure(Player.Black,6),new Figure(Player.Black,6) },
            { new Figure(Player.Black,5),new Figure(Player.Black,4),new Figure(Player.Black,3),new Figure(Player.Black,2),new Figure(Player.Black,2),new Figure(Player.Black,3),new Figure(Player.Black,4),new Figure(Player.Black,5) },
        };
    }
}
