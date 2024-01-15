using System.Drawing;

namespace ChessClassLibrary.ChessField
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
        /// <summary>
        /// Проверяет, находится ли вызываемая ячейка внутри границ игрового поля
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public bool InsideBorder(int row, int col)
        {
            if (row >= 8 || col >= 8 || row < 0 || col < 0)
                return false;
            return true;
        }
        /// <summary>
        /// Возвращает массив доступных ходов для пешки
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="currentPlayer"></param>
        /// <returns></returns>
        public bool[,] GetPawnSteps(int row, int col, Player currentPlayer)
        {
            bool[,] active = new bool[8, 8];
            int playerDefinition = currentPlayer == Player.White ? 1 : -1;
            var positionShift = new Position(row + 1 * playerDefinition, col);
            if (InsideBorder(row + 1 * playerDefinition, col) && GetFigure(positionShift) == 0)
            {
                if (row == 1 && currentPlayer == Player.White || row == 6 && currentPlayer == Player.Black)
                {
                    active[row + 1 * playerDefinition, col] = true;
                    active[row + 2 * playerDefinition, col] = true;
                }
                else
                {
                    active[row + 1 * playerDefinition, col] = true;
                }
            }
            if (InsideBorder(row + 1 * playerDefinition, col + 1))
            {
                if (GetFigure(row + 1 * playerDefinition, col + 1) != 0 && GetPlayer(row + 1 * playerDefinition, col + 1) != currentPlayer)
                {
                    active[row + 1 * playerDefinition, col + 1]= true;
                }
            }
            if (InsideBorder(row + 1 * playerDefinition, col - 1))
            {
                if (GetFigure(row + 1 * playerDefinition, col - 1) != 0 && GetPlayer(row + 1 * playerDefinition, col - 1) != currentPlayer)
                {
                    active[row + 1 * playerDefinition, col - 1] = true;
                }
            }
            return active;
        }
        /// <summary>
        /// Возвращает булевый массив доступных ходов для коня
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public bool[,] GetHourseSteps(int row, int col)
        {
            bool[,] active = new bool[8, 8];
            if (InsideBorder(row - 2, col + 1)) active[row - 2, col + 1] = true;
            if (InsideBorder(row - 2, col - 1)) active[row - 2, col - 1] = true;
            if (InsideBorder(row + 2, col + 1)) active[row + 2, col + 1] = true;
            if (InsideBorder(row + 2, col - 1)) active[row + 2, col - 1] = true;
            if (InsideBorder(row - 1, col + 2)) active[row - 1, col + 2] = true;
            if (InsideBorder(row + 1, col + 2)) active[row + 1, col + 2] = true;
            if (InsideBorder(row - 1, col - 2)) active[row - 1, col - 2] = true;
            if (InsideBorder(row + 1, col - 2)) active[row + 1, col - 2] = true;
            return active;
        }
        // TODO: Доделать функцию получения диагональных ходов
        public bool[,] GetDiagonalSteps(int row, int col, Player player, bool isOneStep = false) 
        {
            bool[,] active = new bool[8, 8];

            int j = col + 1;
            for (int i = row - 1; i >= 0; i--)
            {
                if (InsideBorder(i, j) && !EnemySpoted(i, j, player))
                {
                    active[i, j] = true;
                    break;
                }
                if (j < 7)
                {
                    active[i, j] = true;
                    j++;
                }
                else break;
                if (isOneStep)
                {
                    active[i, j] = true;
                    break;
                }
            }
            j = col - 1;
            for (int i = row - 1; i >= 0; i--)
            {
                if (InsideBorder(i, j) && !EnemySpoted(i, j, player))
                {
                    active[i, j] = true;
                    break;
                }
                if (j > 0) {
                    active[i, j] = true;
                    j--;
                }
                else break;
                if (isOneStep) break;
            }
            j = col - 1;
            for (int i = row + 1; i < 8; i++)
            {
                if (InsideBorder(i, j) && !EnemySpoted(i, j, player))
                {
                    active[i, j] = true;
                    break;
                }
                if (j > 0) {
                    active[i, j] = true;
                    j--;
                }
                else break;
                if (isOneStep) break;
            }
            j = col + 1;
            for (int i = row + 1; i < 8; i++)
            {
                if (InsideBorder(i, j) && !EnemySpoted(i, j, player))
                {
                    active[i, j] = true;
                    break;
                }
                if (j < 7) 
                {
                    active[i, j] = true;
                    j++;
                }
                else break;
                if (isOneStep) break;
            }
            return active;
        }
        //TODO: Доделать
        private bool EnemySpoted(int row, int col, Player player)
        {
            if(GetFigure(row, col) != 0)
            {
                if (GetPlayer(row, col) != player) 
                {
                    //
                }
                return false;
            }
            return true;
        }
    }
}