using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using chess.Forms.ChessField;
using chess.Properties;
using Chess;

namespace Chess.Forms
{
    public partial class ChessField : Form
    {
        public int scoreFirst  = 0;
        public int scoreSecond = 0;
        public bool timerEnable = false;
        public int timer = 0;
        public Font mainFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        public ChessField()
        {
            InitializeComponent();
            chessSprites = new Bitmap(Resources.chess);
            currPlayer = Player.White;
            UpdateInformationLabels();
            UpdateDebugFields();
            CreateMap();
        }
        public Image chessSprites;
        public GameEngine engine = new GameEngine(new Map());

        public Button[,] butts = new Button[8, 8];
        public Player currPlayer;
        public Button prevButton;
        public bool isMoving = false;
        public void CreateMap()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    butts[i, j] = new Button();
                    Button butt = new Button();
                    butt.Size = new Size(50, 50);
                    butt.Location = new Point(j * 50, i * 50);
                    switch (map[i, j] / 10)
                    {
                        case 1:
                            Image part = new Bitmap(50, 50);
                            Graphics g = Graphics.FromImage(part);
                            g.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0 + 150 * (map[i, j] % 10 - 1), 0, 150, 150, GraphicsUnit.Pixel);
                            butt.BackgroundImage = part;
                            break;
                        case 2:
                            Image part1 = new Bitmap(50, 50);
                            Graphics g1 = Graphics.FromImage(part1);
                            g1.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0 + 150 * (map[i, j] % 10 - 1), 150, 150, 150, GraphicsUnit.Pixel);
                            butt.BackgroundImage = part1;
                            break;
                    }
                    butt.BackColor = Color.White;
                    butt.Click += new EventHandler(OnFigurePress);
                    this.Controls.Add(butt);
                    butts[i, j] = butt;
                }
            }
        }
        public void UpdateInformationLabels()
        {
            ScoreFisrtLabel.Font = mainFont; ScoreSecondLabel.Font = mainFont; CurrentPlayerLabel.Font = mainFont;
            ScoreFisrtLabel.Text  = $"First player score: {scoreFirst}";
            ScoreSecondLabel.Text = $"Second player score: {scoreSecond}";
            if (currPlayer == 1) CurrentPlayerLabel.Text = $"Current player: white";
            else                 CurrentPlayerLabel.Text = $"Current player: black";
        }


        public void OnFigurePress(object sender, EventArgs e)
        {

            UpdateDebugFields();

            Button pressedButton = sender as Button;
            Position clickedCellPosition = new Position(pressedButton.Location.Y / 50, pressedButton.Location.X / 50);
            
            if (prevButton != null)
                prevButton.BackColor = Color.White;
            if (engine.GetType(clickedCellPosition) != 0 && engine.GetPlayer(clickedCellPosition) == currPlayer)
            {
                CloseSteps();
                pressedButton.BackColor = Color.Red;
                DeactivateAllButtons();
                pressedButton.Enabled = true;
                ShowSteps(engine.FigureTypeX(clickedCellPosition), engine.FigureTypeY(clickedCellPosition), engine.GetType(clickedCellPosition));
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
                    Position temp = clickedCellPosition;
                    engine.Map = map[prevButton.Location.Y / 50, prevButton.Location.X / 50];
                    if(temp % 10 != 00)
                    {
                        map[prevButton.Location.Y / 50, prevButton.Location.X / 50] = 00;
                        if (currPlayer == Player.White) scoreFirst++;
                        else scoreSecond++;
                    }
                    else map[prevButton.Location.Y / 50, prevButton.Location.X / 50] = temp;
                    pressedButton.BackgroundImage = prevButton.BackgroundImage;
                    prevButton.BackgroundImage = null;
                    isMoving = false;
                    CloseSteps();
                    ActivateAllButtons();
                    SwitchPlayer();
                }
            }
            prevButton = pressedButton;
        }

        private void UpdateDebugFields()
        {
            DebugField.Font = mainFont;
            DebugTimer.Font = mainFont;
            DebugInfoLabel.Font = mainFont;
            string str = "";
            for (int i = 0; i < 8; i++)
            {
                for (int ii = 0; ii < 8; ii++)
                {
                    //if (map[i, ii] <= 10) str += "0" + map[i, ii];
                    //else str += map[i, ii];
                    str += " ";
                }
                str += "\n";
            }
            DebugField.Text = str;
        }

        public void ShowSteps(List<Position> requiredToRecolor)
        {
            foreach(Position position in requiredToRecolor)
            {
                butts[position.X,position.Y].BackColor = Color.Yellow;
                butts[position.X, position.Y].Enabled = true;
            }
        }
        public void ShowSteps(int IcurrFigure, int JcurrFigure, int currFigure)
        {
            int dir = currPlayer == Player.White ? 1 : -1;
            switch (currFigure % 10)
            {
                case 6:
                    if (InsideBorder(IcurrFigure + 1 * dir, JcurrFigure))
                    {
                        if (map[IcurrFigure + 1 * dir, JcurrFigure] == 0)
                        {
                            if (IcurrFigure == 1 && currPlayer == Player.White || IcurrFigure == 6 && currPlayer == Player.Black)
                            {
                                butts[IcurrFigure + 1 * dir, JcurrFigure].BackColor = Color.Yellow;
                                butts[IcurrFigure + 2 * dir, JcurrFigure].BackColor = Color.Yellow;
                                butts[IcurrFigure + 1 * dir, JcurrFigure].Enabled = true;
                                butts[IcurrFigure + 2 * dir, JcurrFigure].Enabled = true;
                            }
                            else
                            {
                                butts[IcurrFigure + 1 * dir, JcurrFigure].BackColor = Color.Yellow;
                                butts[IcurrFigure + 1 * dir, JcurrFigure].Enabled = true;
                            }
                        }
                    }
                    if (InsideBorder(IcurrFigure + 1 * dir, JcurrFigure + 1))
                    {
                        if (map[IcurrFigure + 1 * dir, JcurrFigure + 1] != 0 && map[IcurrFigure + 1 * dir, JcurrFigure + 1] / 10 != currPlayer)
                        {
                            butts[IcurrFigure + 1 * dir, JcurrFigure + 1].BackColor = Color.Yellow;
                            butts[IcurrFigure + 1 * dir, JcurrFigure + 1].Enabled = true;
                        }
                    }
                    if (InsideBorder(IcurrFigure + 1 * dir, JcurrFigure - 1))
                    {
                        if (map[IcurrFigure + 1 * dir, JcurrFigure - 1] != 0 && map[IcurrFigure + 1 * dir, JcurrFigure - 1] / 10 != currPlayer)
                        {
                            butts[IcurrFigure + 1 * dir, JcurrFigure - 1].BackColor = Color.Yellow;
                            butts[IcurrFigure + 1 * dir, JcurrFigure - 1].Enabled = true;
                        }
                    }
                    break;
                case 5:
                    ShowVerticalHorizontal(IcurrFigure, JcurrFigure);
                    break;
                case 3:
                    ShowDiagonal(IcurrFigure, JcurrFigure);
                    break;
                case 2:
                    ShowVerticalHorizontal(IcurrFigure, JcurrFigure);
                    ShowDiagonal(IcurrFigure, JcurrFigure);
                    break;
                case 1:
                    ShowVerticalHorizontal(IcurrFigure, JcurrFigure, true);
                    ShowDiagonal(IcurrFigure, JcurrFigure, true);
                    break;
                case 4:
                    ShowHorseSteps(IcurrFigure, JcurrFigure);
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

        public void ShowDiagonal(int IcurrFigure, int JcurrFigure, bool isOneStep = false)
        {
            int j = JcurrFigure + 1;
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (InsideBorder(i, j) && !DeterminePath(i, j)) break;
                if (j < 7) j++;
                else break;
                if (isOneStep) break;
            }
            j = JcurrFigure - 1;
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (InsideBorder(i, j) && !DeterminePath(i, j)) break;
                if (j > 0) j--;
                else break;
                if (isOneStep) break;
            }
            j = JcurrFigure - 1;
            for (int i = IcurrFigure + 1; i < 8; i++)
            {
                if (InsideBorder(i, j) && !DeterminePath(i, j)) break;
                if (j > 0) j--;
                else break;
                if (isOneStep) break;
            }
            j = JcurrFigure + 1;
            for (int i = IcurrFigure + 1; i < 8; i++)
            {
                if (InsideBorder(i, j) && !DeterminePath(i, j)) break;
                if (j < 7) j++;
                else break;
                if (isOneStep) break;
            }
        }

        public void ShowVerticalHorizontal(int IcurrFigure, int JcurrFigure, bool isOneStep = false)
        {
            for (int i = IcurrFigure + 1; i < 8; i++)
            {
                if (InsideBorder(i, JcurrFigure) && !DeterminePath(i, JcurrFigure)) break;
                if (isOneStep) break;
            }
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (InsideBorder(i, JcurrFigure) && !DeterminePath(i, JcurrFigure)) break;
                if (isOneStep) break;
            }
            for (int j = JcurrFigure + 1; j < 8; j++)
            {
                if (InsideBorder(IcurrFigure, j) && !DeterminePath(IcurrFigure, j)) break;
                if (isOneStep) break;
            }
            for (int j = JcurrFigure - 1; j >= 0; j--)
            {
                if (InsideBorder(IcurrFigure, j) && !DeterminePath(IcurrFigure, j)) break;
                if (isOneStep) break;
            }
        }

        public bool DeterminePath(int IcurrFigure, int j)
        {
            if (map[IcurrFigure, j] == 0)
            {
                butts[IcurrFigure, j].BackColor = Color.Yellow;
                butts[IcurrFigure, j].Enabled = true;
            }
            else
            {
                if (map[IcurrFigure, j] / 10 != currPlayer)
                {
                    butts[IcurrFigure, j].BackColor = Color.Yellow;
                    butts[IcurrFigure, j].Enabled = true;
                }
                return false;
            }
            return true;
        }

        public bool InsideBorder(int ti, int tj)
        {
            if (ti >= 8 || tj >= 8 || ti < 0 || tj < 0) 
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
            currPlayer = currPlayer == Player.White ? Player.Black : Player.White;
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
