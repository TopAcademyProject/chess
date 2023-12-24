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
            this.SuspendLayout();
            // 
            // DebugField
            // 
            this.DebugField.AutoSize = true;
            this.DebugField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DebugField.Location = new System.Drawing.Point(405, 51);
            this.DebugField.Name = "DebugField";
            this.DebugField.Size = new System.Drawing.Size(75, 25);
            this.DebugField.TabIndex = 0;
            this.DebugField.Text = "Debug";
            // 
            // DebugPlayer
            // 
            this.DebugPlayer.AutoSize = true;
            this.DebugPlayer.Location = new System.Drawing.Point(407, 8);
            this.DebugPlayer.Name = "DebugPlayer";
            this.DebugPlayer.Size = new System.Drawing.Size(39, 13);
            this.DebugPlayer.TabIndex = 1;
            this.DebugPlayer.Text = "Debug";
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}