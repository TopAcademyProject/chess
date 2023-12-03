namespace Chess
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonSafeGame = new System.Windows.Forms.Button();
            this.buttonLoadGame = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panelGameInfo = new System.Windows.Forms.Panel();
            this.labelGameInfo = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelGameFieldTest = new System.Windows.Forms.Panel();
            this.labelFirstPlayer = new System.Windows.Forms.Label();
            this.textBoxFirstPlayer = new System.Windows.Forms.TextBox();
            this.labelSecondPlayer = new System.Windows.Forms.Label();
            this.textBoxSecondPlayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelScoreFirstPlayer = new System.Windows.Forms.Label();
            this.labelScoreSecondPlayer = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonSaveScore = new System.Windows.Forms.Button();
            this.labelLogoName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelGameInfo.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Controls.Add(this.buttonLoadGame);
            this.panel1.Controls.Add(this.buttonSafeGame);
            this.panel1.Controls.Add(this.buttonNewGame);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 540);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNewGame.FlatAppearance.BorderSize = 0;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNewGame.Location = new System.Drawing.Point(0, 60);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(220, 60);
            this.buttonNewGame.TabIndex = 2;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            // 
            // buttonSafeGame
            // 
            this.buttonSafeGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSafeGame.FlatAppearance.BorderSize = 0;
            this.buttonSafeGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSafeGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSafeGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSafeGame.Location = new System.Drawing.Point(0, 120);
            this.buttonSafeGame.Name = "buttonSafeGame";
            this.buttonSafeGame.Size = new System.Drawing.Size(220, 60);
            this.buttonSafeGame.TabIndex = 3;
            this.buttonSafeGame.Text = "Safe Game";
            this.buttonSafeGame.UseVisualStyleBackColor = true;
            // 
            // buttonLoadGame
            // 
            this.buttonLoadGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoadGame.FlatAppearance.BorderSize = 0;
            this.buttonLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonLoadGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLoadGame.Location = new System.Drawing.Point(0, 180);
            this.buttonLoadGame.Name = "buttonLoadGame";
            this.buttonLoadGame.Size = new System.Drawing.Size(220, 60);
            this.buttonLoadGame.TabIndex = 4;
            this.buttonLoadGame.Text = "Load Game";
            this.buttonLoadGame.UseVisualStyleBackColor = true;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQuit.FlatAppearance.BorderSize = 0;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonQuit.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonQuit.Location = new System.Drawing.Point(0, 240);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(220, 60);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            // 
            // panelGameInfo
            // 
            this.panelGameInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelGameInfo.Controls.Add(this.labelGameInfo);
            this.panelGameInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGameInfo.Location = new System.Drawing.Point(220, 0);
            this.panelGameInfo.Name = "panelGameInfo";
            this.panelGameInfo.Size = new System.Drawing.Size(716, 59);
            this.panelGameInfo.TabIndex = 2;
            // 
            // labelGameInfo
            // 
            this.labelGameInfo.AutoSize = true;
            this.labelGameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelGameInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelGameInfo.Location = new System.Drawing.Point(6, 20);
            this.labelGameInfo.Name = "labelGameInfo";
            this.labelGameInfo.Size = new System.Drawing.Size(162, 20);
            this.labelGameInfo.TabIndex = 0;
            this.labelGameInfo.Text = "Game for n-players";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.labelLogoName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // panelGameFieldTest
            // 
            this.panelGameFieldTest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelGameFieldTest.Location = new System.Drawing.Point(283, 145);
            this.panelGameFieldTest.Name = "panelGameFieldTest";
            this.panelGameFieldTest.Size = new System.Drawing.Size(343, 304);
            this.panelGameFieldTest.TabIndex = 4;
            // 
            // labelFirstPlayer
            // 
            this.labelFirstPlayer.AutoSize = true;
            this.labelFirstPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelFirstPlayer.Location = new System.Drawing.Point(640, 120);
            this.labelFirstPlayer.Name = "labelFirstPlayer";
            this.labelFirstPlayer.Size = new System.Drawing.Size(105, 20);
            this.labelFirstPlayer.TabIndex = 5;
            this.labelFirstPlayer.Text = "First PLayer";
            // 
            // textBoxFirstPlayer
            // 
            this.textBoxFirstPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.textBoxFirstPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstPlayer.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxFirstPlayer.Location = new System.Drawing.Point(644, 154);
            this.textBoxFirstPlayer.Name = "textBoxFirstPlayer";
            this.textBoxFirstPlayer.Size = new System.Drawing.Size(150, 26);
            this.textBoxFirstPlayer.TabIndex = 6;
            this.textBoxFirstPlayer.Text = "<USERNAME>";
            // 
            // labelSecondPlayer
            // 
            this.labelSecondPlayer.AutoSize = true;
            this.labelSecondPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelSecondPlayer.Location = new System.Drawing.Point(640, 200);
            this.labelSecondPlayer.Name = "labelSecondPlayer";
            this.labelSecondPlayer.Size = new System.Drawing.Size(124, 20);
            this.labelSecondPlayer.TabIndex = 7;
            this.labelSecondPlayer.Text = "Second Player";
            // 
            // textBoxSecondPlayer
            // 
            this.textBoxSecondPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.textBoxSecondPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxSecondPlayer.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxSecondPlayer.Location = new System.Drawing.Point(644, 240);
            this.textBoxSecondPlayer.Name = "textBoxSecondPlayer";
            this.textBoxSecondPlayer.Size = new System.Drawing.Size(150, 26);
            this.textBoxSecondPlayer.TabIndex = 8;
            this.textBoxSecondPlayer.Text = "<USERNAME>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(828, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Score";
            // 
            // labelScoreFirstPlayer
            // 
            this.labelScoreFirstPlayer.AutoSize = true;
            this.labelScoreFirstPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelScoreFirstPlayer.Location = new System.Drawing.Point(851, 154);
            this.labelScoreFirstPlayer.Name = "labelScoreFirstPlayer";
            this.labelScoreFirstPlayer.Size = new System.Drawing.Size(19, 20);
            this.labelScoreFirstPlayer.TabIndex = 10;
            this.labelScoreFirstPlayer.Text = "0";
            // 
            // labelScoreSecondPlayer
            // 
            this.labelScoreSecondPlayer.AutoSize = true;
            this.labelScoreSecondPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelScoreSecondPlayer.Location = new System.Drawing.Point(851, 246);
            this.labelScoreSecondPlayer.Name = "labelScoreSecondPlayer";
            this.labelScoreSecondPlayer.Size = new System.Drawing.Size(19, 20);
            this.labelScoreSecondPlayer.TabIndex = 11;
            this.labelScoreSecondPlayer.Text = "0";
            this.labelScoreSecondPlayer.Click += new System.EventHandler(this.labelScoreSecondPlayer_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRestart.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRestart.Location = new System.Drawing.Point(644, 414);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(111, 35);
            this.buttonRestart.TabIndex = 12;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            // 
            // buttonSaveScore
            // 
            this.buttonSaveScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonSaveScore.FlatAppearance.BorderSize = 0;
            this.buttonSaveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSaveScore.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSaveScore.Location = new System.Drawing.Point(773, 414);
            this.buttonSaveScore.Name = "buttonSaveScore";
            this.buttonSaveScore.Size = new System.Drawing.Size(111, 35);
            this.buttonSaveScore.TabIndex = 13;
            this.buttonSaveScore.Text = "Save Score";
            this.buttonSaveScore.UseVisualStyleBackColor = false;
            // 
            // labelLogoName
            // 
            this.labelLogoName.AutoSize = true;
            this.labelLogoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelLogoName.Location = new System.Drawing.Point(78, 19);
            this.labelLogoName.Name = "labelLogoName";
            this.labelLogoName.Size = new System.Drawing.Size(57, 20);
            this.labelLogoName.TabIndex = 0;
            this.labelLogoName.Text = "label2";
            this.labelLogoName.Click += new System.EventHandler(this.label2_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(936, 540);
            this.Controls.Add(this.buttonSaveScore);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelScoreSecondPlayer);
            this.Controls.Add(this.labelScoreFirstPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSecondPlayer);
            this.Controls.Add(this.labelSecondPlayer);
            this.Controls.Add(this.textBoxFirstPlayer);
            this.Controls.Add(this.labelFirstPlayer);
            this.Controls.Add(this.panelGameFieldTest);
            this.Controls.Add(this.panelGameInfo);
            this.Controls.Add(this.panel1);
            this.Name = "main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panelGameInfo.ResumeLayout(false);
            this.panelGameInfo.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonLoadGame;
        private System.Windows.Forms.Button buttonSafeGame;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelGameInfo;
        private System.Windows.Forms.Label labelGameInfo;
        private System.Windows.Forms.Panel panelGameFieldTest;
        private System.Windows.Forms.Label labelFirstPlayer;
        private System.Windows.Forms.TextBox textBoxFirstPlayer;
        private System.Windows.Forms.Label labelSecondPlayer;
        private System.Windows.Forms.TextBox textBoxSecondPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScoreFirstPlayer;
        private System.Windows.Forms.Label labelScoreSecondPlayer;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonSaveScore;
        private System.Windows.Forms.Label labelLogoName;
    }
}

