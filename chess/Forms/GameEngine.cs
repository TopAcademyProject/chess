using chess.Forms.ChessField;
using System.Collections.Generic;

namespace Chess.Forms
{
    public class GameEngine
    {
        private Map map;

        public GameEngine(Map map) => Map = map;

        public Map Map { get => map; set => map = value; }
        /// <summary>
        /// Возвращает идентификатор фигуры в ячейке по позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int GetFigure(Position position) => Map.Figures[position.X, position.Y].Value;
        /// <summary>
        /// Возвращает идентификатор фигуры в ячейке по координатам
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public int GetFigure(int row, int col) => Map.Figures[row, col].Value;
        //public FigureType GetType(Position position) => Map.Figures[position.X, position.Y].Value;
        /// <summary>
        /// Возвращает позицию по вертикали
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int GetFigurePosX(Position position) => position.X;
        /// <summary>
        /// Возвращает позицию по горизонтали
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int GetFigurePosY(Position position) => position.Y;
        /// <summary>
        /// Возвращает данные об игроке в ячейке по позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public Player GetPlayer(Position position) => Map.Figures[position.X, position.Y].Player;
        /// <summary>
        /// Возвращает данные об игроке в ячейке по координатам
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public Player GetPlayer(int row, int col) => Map.Figures[row, col].Player;
        /// <summary>
        /// Задать значение фигуры на поле
        /// </summary>
        /// <param name="position"></param>
        /// <param name="figure"></param>
        public void SetFigure(Position position, Figure figure) => Map.Figures[(int)position.X, (int)position.Y] = figure;
        /// <summary>
        /// Возвращает класс Figure со своствами Player и Position
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public Figure GetFigureData(Position position) => new Figure(GetPlayer(position), GetFigure(position));

        /*        
         public List<Position> showSteps(Position figurePosition)
         {
              return Map.GetCell(figurePosition).ShowSteps(figurePosition);
         }
        */
    }
}