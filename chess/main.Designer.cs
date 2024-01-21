namespace Chess
{
    partial class main
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
            this.SideBar = new System.Windows.Forms.Panel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonLoadGame = new System.Windows.Forms.Button();
            this.buttonSaveGame = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogoName = new System.Windows.Forms.Label();
            this.panelGameInfo = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.labelGameInfo = new System.Windows.Forms.Label();
            this.panelFormField = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelGameInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.SideBar.Controls.Add(this.buttonQuit);
            this.SideBar.Controls.Add(this.buttonLoadGame);
            this.SideBar.Controls.Add(this.buttonSaveGame);
            this.SideBar.Controls.Add(this.buttonNewGame);
            this.SideBar.Controls.Add(this.panelLogo);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(220, 598);
            this.SideBar.TabIndex = 3;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQuit.FlatAppearance.BorderSize = 0;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuit.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonQuit.Location = new System.Drawing.Point(0, 240);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(220, 60);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonLoadGame
            // 
            this.buttonLoadGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoadGame.Enabled = false;
            this.buttonLoadGame.FlatAppearance.BorderSize = 0;
            this.buttonLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadGame.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLoadGame.Location = new System.Drawing.Point(0, 180);
            this.buttonLoadGame.Name = "buttonLoadGame";
            this.buttonLoadGame.Size = new System.Drawing.Size(220, 60);
            this.buttonLoadGame.TabIndex = 4;
            this.buttonLoadGame.Text = "Load Game";
            this.buttonLoadGame.UseVisualStyleBackColor = true;
            // 
            // buttonSaveGame
            // 
            this.buttonSaveGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSaveGame.Enabled = false;
            this.buttonSaveGame.FlatAppearance.BorderSize = 0;
            this.buttonSaveGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveGame.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSaveGame.Location = new System.Drawing.Point(0, 120);
            this.buttonSaveGame.Name = "buttonSaveGame";
            this.buttonSaveGame.Size = new System.Drawing.Size(220, 60);
            this.buttonSaveGame.TabIndex = 3;
            this.buttonSaveGame.Text = "Save Game";
            this.buttonSaveGame.UseVisualStyleBackColor = true;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNewGame.FlatAppearance.BorderSize = 0;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNewGame.Location = new System.Drawing.Point(0, 60);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(220, 60);
            this.buttonNewGame.TabIndex = 2;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
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
            // labelLogoName
            // 
            this.labelLogoName.AutoSize = true;
            this.labelLogoName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogoName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLogoName.Location = new System.Drawing.Point(54, 20);
            this.labelLogoName.Name = "labelLogoName";
            this.labelLogoName.Size = new System.Drawing.Size(117, 25);
            this.labelLogoName.TabIndex = 0;
            this.labelLogoName.Text = "Chess Game";
            // 
            // panelGameInfo
            // 
            this.panelGameInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelGameInfo.Controls.Add(this.btnCloseChildForm);
            this.panelGameInfo.Controls.Add(this.labelGameInfo);
            this.panelGameInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGameInfo.Location = new System.Drawing.Point(220, 0);
            this.panelGameInfo.Name = "panelGameInfo";
            this.panelGameInfo.Size = new System.Drawing.Size(927, 59);
            this.panelGameInfo.TabIndex = 5;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseChildForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCloseChildForm.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCloseChildForm.Location = new System.Drawing.Point(907, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(20, 20);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Text = "X";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // labelGameInfo
            // 
            this.labelGameInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGameInfo.AutoSize = true;
            this.labelGameInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelGameInfo.Location = new System.Drawing.Point(434, 20);
            this.labelGameInfo.Name = "labelGameInfo";
            this.labelGameInfo.Size = new System.Drawing.Size(66, 25);
            this.labelGameInfo.TabIndex = 0;
            this.labelGameInfo.Text = "Home";
            // 
            // panelFormField
            // 
            this.panelFormField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormField.Location = new System.Drawing.Point(220, 59);
            this.panelFormField.Name = "panelFormField";
            this.panelFormField.Size = new System.Drawing.Size(927, 539);
            this.panelFormField.TabIndex = 6;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 598);
            this.Controls.Add(this.panelFormField);
            this.Controls.Add(this.panelGameInfo);
            this.Controls.Add(this.SideBar);
            this.Name = "main";
            this.Text = "main";
            this.SideBar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelGameInfo.ResumeLayout(false);
            this.panelGameInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonLoadGame;
        private System.Windows.Forms.Button buttonSaveGame;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLogoName;
        private System.Windows.Forms.Panel panelGameInfo;
        private System.Windows.Forms.Label labelGameInfo;
        private System.Windows.Forms.Panel panelFormField;
        private System.Windows.Forms.Button btnCloseChildForm;
    }
}