namespace Chess.Forms
{
    partial class Field
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
            this.DebugField = new System.Windows.Forms.Label();
            this.DebugPlayer = new System.Windows.Forms.Label();
            this.ScoreFisrtLabel = new System.Windows.Forms.Label();
            this.ScoreSecondLabel = new System.Windows.Forms.Label();
            this.CurrentPlayerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DebugField
            // 
            this.DebugField.AutoSize = true;
            this.DebugField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DebugField.Location = new System.Drawing.Point(417, 262);
            this.DebugField.Name = "DebugField";
            this.DebugField.Size = new System.Drawing.Size(151, 25);
            this.DebugField.TabIndex = 0;
            this.DebugField.Text = "DEBUG FIELD";
            // 
            // DebugPlayer
            // 
            this.DebugPlayer.AutoSize = true;
            this.DebugPlayer.Location = new System.Drawing.Point(419, 219);
            this.DebugPlayer.Name = "DebugPlayer";
            this.DebugPlayer.Size = new System.Drawing.Size(45, 13);
            this.DebugPlayer.TabIndex = 1;
            this.DebugPlayer.Text = "DEBUG";
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
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CurrentPlayerLabel);
            this.Controls.Add(this.ScoreSecondLabel);
            this.Controls.Add(this.ScoreFisrtLabel);
            this.Controls.Add(this.DebugPlayer);
            this.Controls.Add(this.DebugField);
            this.Name = "Field";
            this.Text = "Field";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DebugField;
        private System.Windows.Forms.Label DebugPlayer;
        private System.Windows.Forms.Label ScoreFisrtLabel;
        private System.Windows.Forms.Label ScoreSecondLabel;
        private System.Windows.Forms.Label CurrentPlayerLabel;
    }
}