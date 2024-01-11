using chess.Forms.ChessField;
using System.Collections.Generic;

namespace Chess.Forms
{
    public class GameEngine
    {
        private Map map;

        public GameEngine(Map map)
        {
            this.Map = map;
        }

        public Map Map { get => map; set => map = value; }

        public int GetType(Position position) => Map.Figures[position.X, position.Y].Value;
        //public FigureType GetType(Position position) => Map.Figures[position.X, position.Y].Value;
        public int FigureTypeX(Position position) => position.X;
        public int FigureTypeY(Position position) => position.Y;
        public Player GetPlayer(Position position) => Map.Figures[position.X, position.Y].Player;

        public void SetState(Position position, Figure figure)
        {
            Map.Figures[(int)position.X, (int)position.Y] = figure;
        }

        public List<Position> showSteps(Position figurePosition)
        {
            return Map.GetCell(figurePosition).ShowSteps(figurePosition);
        }
    }
}