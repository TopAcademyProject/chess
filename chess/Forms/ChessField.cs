using chess.Properties;
using ChessClassLibrary.ChessField;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chess.Forms
{
    public partial class ChessField : Form
    {
        public int scoreFirst = 0;
        public int scoreSecond = 0;
        public bool timerEnable = false;
        public int timer = 0;
        public Font mainFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        Position clickedCellPosition;
        Position prevClickedCellPosition;
        public ChessField()
        {
            InitializeComponent();
            chessSprites = new Bitmap(Resources.chess);
            currentPlayer = Player.White;
            UpdateInformationLabels();
            UpdateDebugFields();
            CreateMap();
        }
        public Image chessSprites;
        public GameEngine engine = new GameEngine(new Map());
        public Button[,] butts = new Button[8, 8];
        public Player currentPlayer;
        public Button prevButton;
        public bool isMoving = false;

        public void CreateMap()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    butts[j, i] = new Button();
                    Button butt = new Button();
                    butt.Size = new Size(50, 50);
                    butt.Location = new Point(i * 50, j * 50);
                    var pos = new Position(j, i);
                    switch (engine.GetPlayer(pos))
                    {
                        case Player.White:
                            Image part = new Bitmap(50, 50);
                            Graphics g = Graphics.FromImage(part);
                            g.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0 + 150 * (engine.GetFigure(pos) - 1), 0, 150, 150, GraphicsUnit.Pixel);
                            butt.BackgroundImage = part;
                            break;
                        case Player.Black:
                            Image part1 = new Bitmap(50, 50);
                            Graphics g1 = Graphics.FromImage(part1);
                            g1.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0 + 150 * (engine.GetFigure(pos) - 1), 150, 150, 150, GraphicsUnit.Pixel);
                            butt.BackgroundImage = part1;
                            break;
                    }
                    butt.BackColor = Color.White;
                    butt.Click += new EventHandler(OnFigurePress);
                    Controls.Add(butt);
                    butts[j, i] = butt;
                }
            }
        }

        public void UpdateInformationLabels()
        {
            ScoreFisrtLabel.Font = mainFont; ScoreSecondLabel.Font = mainFont; CurrentPlayerLabel.Font = mainFont;
            ScoreFisrtLabel.Text = $"First player score: {scoreFirst}";
            ScoreSecondLabel.Text = $"Second player score: {scoreSecond}";
            CurrentPlayerLabel.Text = $"Current player: {currentPlayer}";
        }

        public void OnFigurePress(object sender, EventArgs e)
        {
            UpdateDebugFields();

            Button pressedButton = sender as Button;
            clickedCellPosition = new Position(pressedButton.Location.Y / 50, pressedButton.Location.X / 50);
            if (prevButton != null)
                prevButton.BackColor = Color.White;
            if (engine.GetFigure(clickedCellPosition) != 0 && engine.GetPlayer(clickedCellPosition) == currentPlayer)
            {
                CloseSteps();
                pressedButton.BackColor = Color.Red;
                DeactivateAllButtons();
                pressedButton.Enabled = true;
                ShowSteps(engine.GetFigurePosX(clickedCellPosition), engine.GetFigurePosY(clickedCellPosition), engine.GetFigure(clickedCellPosition));
                if (isMoving)
                {
                    CloseSteps();
                    pressedButton.BackColor = Color.White;
                    ActivateAllButtons();
                    isMoving = false;
                }
                else isMoving = true;
            }
            else
            {
                if (isMoving)
                {
                    var tempClickedCellPosition = engine.GetFigure(clickedCellPosition);
                    engine.SetFigure(clickedCellPosition, new Figure(currentPlayer, engine.GetFigure(prevClickedCellPosition)));
                    if (tempClickedCellPosition != 0)
                    {
                        engine.SetFigure(prevClickedCellPosition, new Figure(Player.Empty, 0));
                        if (currentPlayer == Player.White) scoreFirst++;
                        else scoreSecond++;
                    }
                    else engine.SetFigure(prevClickedCellPosition, new Figure(currentPlayer, tempClickedCellPosition));
                    pressedButton.BackgroundImage = prevButton.BackgroundImage;
                    clickedCellPosition = prevClickedCellPosition;
                    prevButton.BackgroundImage = null;
                    isMoving = false;
                    CloseSteps();
                    ActivateAllButtons();
                    SwitchPlayer();
                }
            }
            prevButton = pressedButton;
            prevClickedCellPosition = new Position(prevButton.Location.Y / 50, prevButton.Location.X / 50);
        }

        private void UpdateDebugFields()
        {
            DebugField.Font = mainFont;
            DebugTimer.Font = mainFont;
            DebugInfoLabel.Font = mainFont;
            DebugPositionClickedLabel.Font = mainFont;
            string str = "";
            for (int i = 0; i < 8; i++)
            {
                for (int ii = 0; ii < 8; ii++)
                {
                    var pos = new Position(i, ii);
                    if (engine.GetFigure(pos) <= 10)
                    {
                        if (engine.GetPlayer(pos) == Player.White) str += '1';
                        else if (engine.GetPlayer(pos) == Player.Black) str += "2";
                        else str += "0";
                        str += engine.GetFigure(pos);
                    }
                    else str += engine.GetFigure(pos);
                    str += " ";
                }
                str += "\n";
            }
            DebugField.Text = str;
        }

        public void ShowSteps(int row, int col, int currentFigure)
        {
            int playerDefinition = currentPlayer == Player.White ? 1 : -1;
            var positionShift = new Position(row + 1 * playerDefinition, col);
            switch (currentFigure)
            {
                case 6:
                    if (InsideBorder(row + 1 * playerDefinition, col))
                    {
                        if (engine.GetFigure(positionShift) == 0)
                        {
                            if (row == 1 && currentPlayer == Player.White || row == 6 && currentPlayer == Player.Black)
                            {
                                butts[row + 1 * playerDefinition, col].BackColor = Color.Yellow;
                                butts[row + 2 * playerDefinition, col].BackColor = Color.Yellow;
                                butts[row + 1 * playerDefinition, col].Enabled = true;
                                butts[row + 2 * playerDefinition, col].Enabled = true;
                            }
                            else
                            {
                                butts[row + 1 * playerDefinition, col].BackColor = Color.Yellow;
                                butts[row + 1 * playerDefinition, col].Enabled = true;
                            }
                        }
                    }
                    if (InsideBorder(row + 1 * playerDefinition, col + 1))
                    {
                        if (engine.GetFigure(row + 1 * playerDefinition, col + 1) != 0 && engine.GetPlayer(row + 1 * playerDefinition, col + 1) != currentPlayer)
                        {
                            butts[row + 1 * playerDefinition, col + 1].BackColor = Color.Yellow;
                            butts[row + 1 * playerDefinition, col + 1].Enabled = true;
                        }
                    }
                    if (InsideBorder(row + 1 * playerDefinition, col - 1))
                    {
                        if (engine.GetFigure(row + 1 * playerDefinition, col - 1) != 0 && engine.GetPlayer(row + 1 * playerDefinition, col - 1) != currentPlayer)
                        {
                            butts[row + 1 * playerDefinition, col - 1].BackColor = Color.Yellow;
                            butts[row + 1 * playerDefinition, col - 1].Enabled = true;
                        }
                    }
                    break;
                case 5:
                    ShowVerticalHorizontal(row, col);
                    break;
                case 3:
                    ShowDiagonal(row, col);
                    break;
                case 2:
                    ShowVerticalHorizontal(row, col);
                    ShowDiagonal(row, col);
                    break;
                case 1:
                    ShowVerticalHorizontal(row, col, true);
                    ShowDiagonal(row, col, true);
                    break;
                case 4:
                    ShowHorseSteps(row, col);
                    break;
            }
        }

        public void ShowHorseSteps(int IcurrFigure, int JcurrFigure)
        {
            if (InsideBorder(IcurrFigure - 2, JcurrFigure + 1)) DeterminePath(IcurrFigure - 2, JcurrFigure + 1);
            if (InsideBorder(IcurrFigure - 2, JcurrFigure - 1)) DeterminePath(IcurrFigure - 2, JcurrFigure - 1);
            if (InsideBorder(IcurrFigure + 2, JcurrFigure + 1)) DeterminePath(IcurrFigure + 2, JcurrFigure + 1);
            if (InsideBorder(IcurrFigure + 2, JcurrFigure - 1)) DeterminePath(IcurrFigure + 2, JcurrFigure - 1);
            if (InsideBorder(IcurrFigure - 1, JcurrFigure + 2)) DeterminePath(IcurrFigure - 1, JcurrFigure + 2);
            if (InsideBorder(IcurrFigure + 1, JcurrFigure + 2)) DeterminePath(IcurrFigure + 1, JcurrFigure + 2);
            if (InsideBorder(IcurrFigure - 1, JcurrFigure - 2)) DeterminePath(IcurrFigure - 1, JcurrFigure - 2);
            if (InsideBorder(IcurrFigure + 1, JcurrFigure - 2)) DeterminePath(IcurrFigure + 1, JcurrFigure - 2);
        }

        public void DeactivateAllButtons()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    butts[i, j].Enabled = false;
        }

        public void ActivateAllButtons()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    butts[i, j].Enabled = true;
        }

        public void ShowDiagonal(int row, int col, bool isOneStep = false)
        {
            int j = col + 1;
            for (int i = row - 1; i >= 0; i--)
            {
                if (InsideBorder(i, j) && !DeterminePath(i, j)) break;
                if (j < 7) j++;
                else break;
                if (isOneStep) break;
            }
            j = col - 1;
            for (int i = row - 1; i >= 0; i--)
            {
                if (InsideBorder(i, j) && !DeterminePath(i, j)) break;
                if (j > 0) j--;
                else break;
                if (isOneStep) break;
            }
            j = col - 1;
            for (int i = row + 1; i < 8; i++)
            {
                if (InsideBorder(i, j) && !DeterminePath(i, j)) break;
                if (j > 0) j--;
                else break;
                if (isOneStep) break;
            }
            j = col + 1;
            for (int i = row + 1; i < 8; i++)
            {
                if (InsideBorder(i, j) && !DeterminePath(i, j)) break;
                if (j < 7) j++;
                else break;
                if (isOneStep) break;
            }
        }

        public void ShowVerticalHorizontal(int row, int col, bool isOneStep = false)
        {
            for (int i = row + 1; i < 8; i++)
            {
                if (InsideBorder(i, col) && !DeterminePath(i, col)) break;
                if (isOneStep) break;
            }
            for (int i = row - 1; i >= 0; i--)
            {
                if (InsideBorder(i, col) && !DeterminePath(i, col)) break;
                if (isOneStep) break;
            }
            for (int j = col + 1; j < 8; j++)
            {
                if (InsideBorder(row, j) && !DeterminePath(row, j)) break;
                if (isOneStep) break;
            }
            for (int j = col - 1; j >= 0; j--)
            {
                if (InsideBorder(row, j) && !DeterminePath(row, j)) break;
                if (isOneStep) break;
            }
        }

        public bool DeterminePath(int row, int col)
        {
            if (engine.GetFigure(row, col) == 0)
            {
                butts[row, col].BackColor = Color.Yellow;
                butts[row, col].Enabled = true;
            }
            else
            {
                if (engine.GetPlayer(row, col) != currentPlayer)
                {
                    butts[row, col].BackColor = Color.Yellow;
                    butts[row, col].Enabled = true;
                }
                return false;
            }
            return true;
        }

        public bool InsideBorder(int row, int col)
        {
            if (row >= 8 || col >= 8 || row < 0 || col < 0)
                return false;
            return true;
        }

        public void CloseSteps()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    butts[i, j].BackColor = Color.White;
        }

        public void SwitchPlayer()
        {
            RoundTimer.Enabled = true;
            currentPlayer = currentPlayer == Player.White ? Player.Black : Player.White;
            UpdateDebugFields();
            UpdateInformationLabels();
        }

        private void SwitchPlayerButton_Click(object sender, EventArgs e) => SwitchPlayer();

        private void RoundTimer_Tick(object sender, EventArgs e)
        {
            timer++;
            DebugTimer.Text = timer.ToString();
        }
    }
}
