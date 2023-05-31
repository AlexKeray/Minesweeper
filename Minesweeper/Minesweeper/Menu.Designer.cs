namespace Minesweeper
{
    partial class Menu
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
            this.startGameBtn = new System.Windows.Forms.Button();
            this.scoreboardBtn = new System.Windows.Forms.Button();
            this.optionsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(540, 258);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(462, 90);
            this.startGameBtn.TabIndex = 0;
            this.startGameBtn.Text = "Start game";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.start_game);
            // 
            // scoreboardBtn
            // 
            this.scoreboardBtn.Location = new System.Drawing.Point(540, 354);
            this.scoreboardBtn.Name = "scoreboardBtn";
            this.scoreboardBtn.Size = new System.Drawing.Size(462, 90);
            this.scoreboardBtn.TabIndex = 1;
            this.scoreboardBtn.Text = "Scoreboard";
            this.scoreboardBtn.UseVisualStyleBackColor = true;
            // 
            // optionsBtn
            // 
            this.optionsBtn.Location = new System.Drawing.Point(540, 450);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(462, 90);
            this.optionsBtn.TabIndex = 2;
            this.optionsBtn.Text = "Options";
            this.optionsBtn.UseVisualStyleBackColor = true;
            this.optionsBtn.Click += new System.EventHandler(this.go_to_options);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.scoreboardBtn);
            this.Controls.Add(this.startGameBtn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button scoreboardBtn;
        private System.Windows.Forms.Button optionsBtn;
    }
}

