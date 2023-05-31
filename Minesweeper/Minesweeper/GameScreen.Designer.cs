namespace Minesweeper
{
    partial class GameScreen
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
            this.gameScreenToMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameScreenToMenuBtn
            // 
            this.gameScreenToMenuBtn.Location = new System.Drawing.Point(12, 12);
            this.gameScreenToMenuBtn.Name = "gameScreenToMenuBtn";
            this.gameScreenToMenuBtn.Size = new System.Drawing.Size(245, 88);
            this.gameScreenToMenuBtn.TabIndex = 0;
            this.gameScreenToMenuBtn.Text = "Menu";
            this.gameScreenToMenuBtn.UseVisualStyleBackColor = true;
            this.gameScreenToMenuBtn.Click += new System.EventHandler(this.return_to_menu_from_gamescreen);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.gameScreenToMenuBtn);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gameScreenToMenuBtn;
    }
}