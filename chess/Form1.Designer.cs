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
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonLoadGame = new System.Windows.Forms.Button();
            this.buttonSafeGame = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLogoName = new System.Windows.Forms.Label();
            this.panelGameInfo = new System.Windows.Forms.Panel();
            this.labelGameInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelGameInfo.SuspendLayout();
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
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.labelLogoName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelLogoName
            // 
            this.labelLogoName.AutoSize = true;
            this.labelLogoName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogoName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLogoName.Location = new System.Drawing.Point(88, 20);
            this.labelLogoName.Name = "labelLogoName";
            this.labelLogoName.Size = new System.Drawing.Size(101, 21);
            this.labelLogoName.TabIndex = 0;
            this.labelLogoName.Text = "Chess Game";
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
            this.labelGameInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelGameInfo.Location = new System.Drawing.Point(6, 20);
            this.labelGameInfo.Name = "labelGameInfo";
            this.labelGameInfo.Size = new System.Drawing.Size(155, 21);
            this.labelGameInfo.TabIndex = 0;
            this.labelGameInfo.Text = "Game for n-players";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(936, 540);
            this.Controls.Add(this.panelGameInfo);
            this.Controls.Add(this.panel1);
            this.Name = "main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelGameInfo.ResumeLayout(false);
            this.panelGameInfo.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label labelLogoName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

