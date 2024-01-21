using chess.Properties;
using ChessClassLibrary.ChessField;
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Chess.Forms
{
    public partial class ChessField : Form
    {
        public int scoreFirst = 0;
        public int scoreSecond = 0;
        public bool timerEnable = false;
        public int timer = 0;
        public int timerWhite = 0;
        public int timerBlack = 0;
        public Font mainFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        Position clickedCellPosition;
        Position prevClickedCellPosition;
        bool gameOver = false;
        bool debugMode = false;
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
        public GameEngine engine = new GameEngine(new Map(true));
        /*
         * Debug  map mode — new Map(true)
         * Normal map mode — new Map()
         */
        public Button[,] butts = new Button[8, 8];
        public Player currentPlayer;
        public Button prevButton;
        public bool WCastlingAbility = true;
        public bool BCastlingAbility = true;
        public bool CastlingInProcess = false;
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
                    Image textureAtlas = new Bitmap(50, 50);
                    Graphics texture = Graphics.FromImage(textureAtlas);
                    switch (engine.GetPlayer(pos))
                    {
                        case Player.White:
                            texture.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0 + 150 * (engine.GetFigure(pos) - 1), 0, 150, 150, GraphicsUnit.Pixel);
                            butt.BackgroundImage = textureAtlas;
                            break;
                        case Player.Black:
                            texture.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0 + 150 * (engine.GetFigure(pos) - 1), 150, 150, 150, GraphicsUnit.Pixel);
                            butt.BackgroundImage = textureAtlas;
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
            ScoreFisrtLabel.Font = mainFont; ScoreSecondLabel.Font = mainFont; CurrentPlayerLabel.Font = mainFont; WinnerLabel.Font = mainFont;
            TimerWhiteLabel.Font = mainFont; TimerBlackLabel.Font = mainFont;
            ScoreFisrtLabel.Text = $"First player score: {scoreFirst}";
            ScoreSecondLabel.Text = $"Second player score: {scoreSecond}";
            WinnerLabel.Text = "";
        }

        public void OnFigurePress(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            clickedCellPosition = new Position(pressedButton.Location.Y / 50, pressedButton.Location.X / 50);
            if (prevButton != null)
                prevButton.BackColor = Color.White;
            if(engine.GetFigure(clickedCellPosition) == 1)
            {
                
            }

            if (pressedButton == butts[0, 4])
            {
                CastlingInProcess = true;
            }

            if (CastlingInProcess)
            {
                if (WCastlingAbility == true && pressedButton == butts[0, 6])
                {
                    Position ShortWhite = new Position(0, 5);
                    Position RRook = new Position(0, 7);
                    engine.SetFigure(ShortWhite, new Figure(Player.White, 5));
                    butts[0, 5].BackgroundImage = butts[0, 7].BackgroundImage;
                    engine.SetFigure(RRook, (new Figure(Player.Empty, 0)));
                    butts[0, 7].BackgroundImage = null;
                }
                else if (WCastlingAbility == true && pressedButton == butts[0, 1])
                {
                    Position LongWhite = new Position(0, 2);
                    Position RRook = new Position(0, 0);
                    engine.SetFigure(LongWhite, new Figure(Player.White, 2));
                    butts[0, 2].BackgroundImage = butts[0, 0].BackgroundImage;
                    engine.SetFigure(RRook, (new Figure(Player.Empty, 0)));
                    butts[0, 0].BackgroundImage = null;
                }
            }

            if (engine.GetFigure(0, 4) != 1)
            {
                WCastlingAbility = false;
            }

            else if (engine.GetFigure(7, 4) != 1)
            {
                BCastlingAbility = false;
            }

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
                        if (engine.GameOver()) gameOver = true;
                        if (currentPlayer == Player.White) scoreFirst++;
                        else scoreSecond++;
                    }
                    else
                    {
                        engine.SetFigure(prevClickedCellPosition, new Figure(currentPlayer, tempClickedCellPosition));
                        engine.SetFigure(prevClickedCellPosition, new Figure(Player.Empty, 0));
                    }
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
            if (!debugMode)
            {
                DebugField.Visible = false;
                DebugGameOverLabel.Visible = false;
                DebugInfoLabel.Visible = false;
                DebugPositionClickedLabel.Visible = false;
                SwitchPlayerButton.Visible = false;
                DebugTimer.Visible = false;
            }
            else
            {
                DebugField.Visible = true;
                DebugGameOverLabel.Visible = true;
                DebugInfoLabel.Visible = true;
                DebugPositionClickedLabel.Visible = true;
                SwitchPlayerButton.Visible = true;
                DebugTimer.Visible = true;
            }
            DebugField.Font = mainFont;
            DebugTimer.Font = mainFont;
            DebugInfoLabel.Font = mainFont;
            DebugGameOverLabel.Font = mainFont;
            DebugPositionClickedLabel.Font = mainFont;
            string gameOverText;
            if (gameOver)
                gameOverText = "over";
            else
                gameOverText = "continue";

            DebugGameOverLabel.Text = $"Game {gameOverText}.";
            string str = "";
            for (int i = 0; i < 0; i++)
                for (int j = 0; j < 0; j++)
                    str = "";
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    var pos = new Position(row, col);
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
            switch (currentFigure)
            {
                case 6:
                    var pawnSteps = engine.GetPawnSteps(row, col, currentPlayer);
                    for (int i = 0; i < 8; i++)
                        for (int j = 0; j < 8; j++)
                            if (pawnSteps[i, j] == true)
                            {
                                butts[i, j].BackColor = Color.Yellow;
                                butts[i, j].Enabled = true;
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
                    ShowShortCastling(row);
                    ShowLongCastling(row);
                    break;
                case 4:
                    ShowHorseSteps(row, col);
                    break;
            }
        }

        public void ShowHorseSteps(int row, int col)
        {
            var hourseSteps = engine.GetHourseSteps(row, col);
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    if (hourseSteps[i, j] == true) DeterminePath(i, j);
        }

        public void DeactivateAllButtons()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    butts[i, j].Enabled = false;
        }

        public void ActivateAllButtons()
        {
            if (gameOver) return;
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    butts[i, j].Enabled = true;
        }

        public void ShowDiagonal(int row, int col, bool isOneStep = false)
        {
            int j = col + 1;
            for (int i = row - 1; i >= 0; i--)
            {
                if (engine.InsideBorder(i, j) && !DeterminePath(i, j)) break;
                if (j < 7) j++;
                else break;
                if (isOneStep) break;
            }
            j = col - 1;
            for (int i = row - 1; i >= 0; i--)
            {
                if (engine.InsideBorder(i, j) && !DeterminePath(i, j)) break;
                if (j > 0) j--;
                else break;
                if (isOneStep) break;
            }
            j = col - 1;
            for (int i = row + 1; i < 8; i++)
            {
                if (engine.InsideBorder(i, j) && !DeterminePath(i, j)) break;
                if (j > 0) j--;
                else break;
                if (isOneStep) break;
            }
            j = col + 1;
            for (int i = row + 1; i < 8; i++)
            {
                if (engine.InsideBorder(i, j) && !DeterminePath(i, j)) break;
                if (j < 7) j++;
                else break;
                if (isOneStep) break;
            }
        }

        public void ShowVerticalHorizontal(int row, int col, bool isOneStep = false)
        {
            for (int i = row + 1; i < 8; i++)
            {
                if (engine.InsideBorder(i, col) && !DeterminePath(i, col)) break;
                if (isOneStep) break;
            }
            for (int i = row - 1; i >= 0; i--)
            {
                if (engine.InsideBorder(i, col) && !DeterminePath(i, col)) break;
                if (isOneStep) break;
            }
            for (int j = col + 1; j < 8; j++)
            {
                if (engine.InsideBorder(row, j) && !DeterminePath(row, j)) break;
                if (isOneStep) break;
            }
            for (int j = col - 1; j >= 0; j--)
            {
                if (engine.InsideBorder(row, j) && !DeterminePath(row, j)) break;
                if (isOneStep) break;
            }
        }

        public void ShowShortCastling(int row)
        {
            if (engine.GetFigure(row, 5) == 0)
            {
                if (WCastlingAbility == true)
                {
                    butts[0, 6].BackColor = Color.Cyan;
                    butts[0, 6].Enabled = true;
                }
            }
        }
        public void ShowLongCastling(int row)
        {
            if (engine.GetFigure(row, 1) == 0)
            {
                if (WCastlingAbility == true)
                {
                    butts[0, 1].BackColor = Color.Cyan;
                    butts[0, 1].Enabled = true;
                }
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
        public void CloseSteps()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    butts[i, j].BackColor = Color.White;
        }

        public void SwitchPlayer()
        {
            UpdateDebugFields();
            UpdateInformationLabels();
            if (isMoving == true)
                DebugPositionClickedLabel.Text = $"It is impossible to change players while you are trying to move pieces!";
            else
            {
                RoundTimer.Enabled = true;
                currentPlayer = currentPlayer == Player.White ? Player.Black : Player.White;
                CurrentPlayerLabel.Text = $"Current player: {currentPlayer}";
                DebugPositionClickedLabel.Text = $"{timer} : Player changed to {currentPlayer}.";
            }
        }

        private void SwitchPlayerButton_Click(object sender, EventArgs e) => SwitchPlayer();

        private void RoundTimer_Tick(object sender, EventArgs e)
        {
            if (gameOver)
            {
                string player;
                if (currentPlayer == Player.Black) player = "Win white!";
                else player = "Win black!";
                WinnerLabel.Text = $"{player}";
                RoundTimer.Enabled = false;
            }
            if (currentPlayer == Player.White) timerWhite++;
            else timerBlack++;
            timer++;
            TimerBlackLabel.Text = $"Black time: {timerBlack}";
            TimerWhiteLabel.Text = $"White time: {timerWhite}";
            DebugTimer.Text = $"Time: {timer}";
        }

        private void ShowDebugMenu_Click(object sender, EventArgs e)
        {
            if(debugMode == true) debugMode = false;
            else                  debugMode = true;
            UpdateDebugFields();
        }
    }
}
