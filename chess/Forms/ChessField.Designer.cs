﻿namespace Chess.Forms
{
    partial class ChessField
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DebugField = new System.Windows.Forms.Label();
            this.DebugTimer = new System.Windows.Forms.Label();
            this.ScoreFisrtLabel = new System.Windows.Forms.Label();
            this.ScoreSecondLabel = new System.Windows.Forms.Label();
            this.CurrentPlayerLabel = new System.Windows.Forms.Label();
            this.SwitchPlayerButton = new System.Windows.Forms.Button();
            this.DebugInfoLabel = new System.Windows.Forms.Label();
            this.RoundTimer = new System.Windows.Forms.Timer(this.components);
            this.DebugPositionClickedLabel = new System.Windows.Forms.Label();
            this.DebugGameOverLabel = new System.Windows.Forms.Label();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.TimerWhiteLabel = new System.Windows.Forms.Label();
            this.TimerBlackLabel = new System.Windows.Forms.Label();
            this.ShowDebugMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DebugField
            // 
            this.DebugField.AutoSize = true;
            this.DebugField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DebugField.Location = new System.Drawing.Point(418, 282);
            this.DebugField.Name = "DebugField";
            this.DebugField.Size = new System.Drawing.Size(151, 25);
            this.DebugField.TabIndex = 0;
            this.DebugField.Text = "DEBUG FIELD";
            // 
            // DebugTimer
            // 
            this.DebugTimer.AutoSize = true;
            this.DebugTimer.Location = new System.Drawing.Point(419, 219);
            this.DebugTimer.Name = "DebugTimer";
            this.DebugTimer.Size = new System.Drawing.Size(82, 13);
            this.DebugTimer.TabIndex = 1;
            this.DebugTimer.Text = "DEBUG TIMER";
            // 
            // ScoreFisrtLabel
            // 
            this.ScoreFisrtLabel.AutoSize = true;
            this.ScoreFisrtLabel.Location = new System.Drawing.Point(419, 7);
            this.ScoreFisrtLabel.Name = "ScoreFisrtLabel";
            this.ScoreFisrtLabel.Size = new System.Drawing.Size(41, 13);
            this.ScoreFisrtLabel.TabIndex = 2;
            this.ScoreFisrtLabel.Text = "Score1";
            // 
            // ScoreSecondLabel
            // 
            this.ScoreSecondLabel.AutoSize = true;
            this.ScoreSecondLabel.Location = new System.Drawing.Point(419, 39);
            this.ScoreSecondLabel.Name = "ScoreSecondLabel";
            this.ScoreSecondLabel.Size = new System.Drawing.Size(41, 13);
            this.ScoreSecondLabel.TabIndex = 3;
            this.ScoreSecondLabel.Text = "Score2";
            // 
            // CurrentPlayerLabel
            // 
            this.CurrentPlayerLabel.AutoSize = true;
            this.CurrentPlayerLabel.Location = new System.Drawing.Point(419, 70);
            this.CurrentPlayerLabel.Name = "CurrentPlayerLabel";
            this.CurrentPlayerLabel.Size = new System.Drawing.Size(36, 13);
            this.CurrentPlayerLabel.TabIndex = 4;
            this.CurrentPlayerLabel.Text = "Player";
            // 
            // SwitchPlayerButton
            // 
            this.SwitchPlayerButton.Location = new System.Drawing.Point(422, 193);
            this.SwitchPlayerButton.Name = "SwitchPlayerButton";
            this.SwitchPlayerButton.Size = new System.Drawing.Size(146, 23);
            this.SwitchPlayerButton.TabIndex = 5;
            this.SwitchPlayerButton.Text = "SWITCH PLAYER";
            this.SwitchPlayerButton.UseVisualStyleBackColor = true;
            this.SwitchPlayerButton.Click += new System.EventHandler(this.SwitchPlayerButton_Click);
            // 
            // DebugInfoLabel
            // 
            this.DebugInfoLabel.AutoSize = true;
            this.DebugInfoLabel.Location = new System.Drawing.Point(420, 163);
            this.DebugInfoLabel.Name = "DebugInfoLabel";
            this.DebugInfoLabel.Size = new System.Drawing.Size(93, 13);
            this.DebugInfoLabel.TabIndex = 6;
            this.DebugInfoLabel.Text = "Debug information";
            // 
            // RoundTimer
            // 
            this.RoundTimer.Interval = 1000;
            this.RoundTimer.Tick += new System.EventHandler(this.RoundTimer_Tick);
            // 
            // DebugPositionClickedLabel
            // 
            this.DebugPositionClickedLabel.AutoSize = true;
            this.DebugPositionClickedLabel.Location = new System.Drawing.Point(420, 249);
            this.DebugPositionClickedLabel.Name = "DebugPositionClickedLabel";
            this.DebugPositionClickedLabel.Size = new System.Drawing.Size(81, 13);
            this.DebugPositionClickedLabel.TabIndex = 7;
            this.DebugPositionClickedLabel.Text = "Position clicked";
            // 
            // DebugGameOverLabel
            // 
            this.DebugGameOverLabel.AutoSize = true;
            this.DebugGameOverLabel.Location = new System.Drawing.Point(596, 198);
            this.DebugGameOverLabel.Name = "DebugGameOverLabel";
            this.DebugGameOverLabel.Size = new System.Drawing.Size(79, 13);
            this.DebugGameOverLabel.TabIndex = 8;
            this.DebugGameOverLabel.Text = "Game continue";
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Location = new System.Drawing.Point(420, 140);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(88, 13);
            this.WinnerLabel.TabIndex = 9;
            this.WinnerLabel.Text = "WINNER LABEL";
            // 
            // TimerWhiteLabel
            // 
            this.TimerWhiteLabel.AutoSize = true;
            this.TimerWhiteLabel.Location = new System.Drawing.Point(420, 92);
            this.TimerWhiteLabel.Name = "TimerWhiteLabel";
            this.TimerWhiteLabel.Size = new System.Drawing.Size(60, 13);
            this.TimerWhiteLabel.TabIndex = 10;
            this.TimerWhiteLabel.Text = "White timer";
            // 
            // TimerBlackLabel
            // 
            this.TimerBlackLabel.AutoSize = true;
            this.TimerBlackLabel.Location = new System.Drawing.Point(420, 115);
            this.TimerBlackLabel.Name = "TimerBlackLabel";
            this.TimerBlackLabel.Size = new System.Drawing.Size(59, 13);
            this.TimerBlackLabel.TabIndex = 11;
            this.TimerBlackLabel.Text = "Black timer";
            // 
            // ShowDebugMenu
            // 
            this.ShowDebugMenu.Location = new System.Drawing.Point(12, 415);
            this.ShowDebugMenu.Name = "ShowDebugMenu";
            this.ShowDebugMenu.Size = new System.Drawing.Size(146, 23);
            this.ShowDebugMenu.TabIndex = 12;
            this.ShowDebugMenu.Text = "Show debug menu";
            this.ShowDebugMenu.UseVisualStyleBackColor = true;
            this.ShowDebugMenu.Click += new System.EventHandler(this.ShowDebugMenu_Click);
            // 
            // ChessField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowDebugMenu);
            this.Controls.Add(this.TimerBlackLabel);
            this.Controls.Add(this.TimerWhiteLabel);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.DebugGameOverLabel);
            this.Controls.Add(this.DebugPositionClickedLabel);
            this.Controls.Add(this.DebugInfoLabel);
            this.Controls.Add(this.SwitchPlayerButton);
            this.Controls.Add(this.CurrentPlayerLabel);
            this.Controls.Add(this.ScoreSecondLabel);
            this.Controls.Add(this.ScoreFisrtLabel);
            this.Controls.Add(this.DebugTimer);
            this.Controls.Add(this.DebugField);
            this.Name = "ChessField";
            this.Text = "Field";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DebugField;
        private System.Windows.Forms.Label DebugTimer;
        private System.Windows.Forms.Label ScoreFisrtLabel;
        private System.Windows.Forms.Label ScoreSecondLabel;
        private System.Windows.Forms.Label CurrentPlayerLabel;
        private System.Windows.Forms.Button SwitchPlayerButton;
        private System.Windows.Forms.Label DebugInfoLabel;
        private System.Windows.Forms.Timer RoundTimer;
        private System.Windows.Forms.Label DebugPositionClickedLabel;
        private System.Windows.Forms.Label DebugGameOverLabel;
        private System.Windows.Forms.Label WinnerLabel;
        private System.Windows.Forms.Label TimerWhiteLabel;
        private System.Windows.Forms.Label TimerBlackLabel;
        private System.Windows.Forms.Button ShowDebugMenu;
    }
}