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
            this.optionsBtn = new System.Windows.Forms.Button();
            this.exitApplicationBtn = new System.Windows.Forms.Button();
            this.menuTitleLabel = new System.Windows.Forms.Label();
            this.scoreboardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startGameBtn
            // 
            this.startGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameBtn.Location = new System.Drawing.Point(237, 190);
            this.startGameBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(461, 90);
            this.startGameBtn.TabIndex = 0;
            this.startGameBtn.Text = "Start game";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.start_game);
            // 
            // optionsBtn
            // 
            this.optionsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsBtn.Location = new System.Drawing.Point(237, 284);
            this.optionsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(461, 90);
            this.optionsBtn.TabIndex = 2;
            this.optionsBtn.Text = "Options";
            this.optionsBtn.UseVisualStyleBackColor = true;
            this.optionsBtn.Click += new System.EventHandler(this.go_to_options);
            // 
            // exitApplicationBtn
            // 
            this.exitApplicationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApplicationBtn.Location = new System.Drawing.Point(237, 472);
            this.exitApplicationBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitApplicationBtn.Name = "exitApplicationBtn";
            this.exitApplicationBtn.Size = new System.Drawing.Size(461, 90);
            this.exitApplicationBtn.TabIndex = 3;
            this.exitApplicationBtn.Text = "Exit";
            this.exitApplicationBtn.UseVisualStyleBackColor = true;
            this.exitApplicationBtn.Click += new System.EventHandler(this.exitApplicationBtn_Click);
            // 
            // menuTitleLabel
            // 
            this.menuTitleLabel.AutoSize = true;
            this.menuTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTitleLabel.Location = new System.Drawing.Point(280, 80);
            this.menuTitleLabel.Name = "menuTitleLabel";
            this.menuTitleLabel.Size = new System.Drawing.Size(385, 69);
            this.menuTitleLabel.TabIndex = 4;
            this.menuTitleLabel.Text = "Minesweeper";
            // 
            // scoreboardBtn
            // 
            this.scoreboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardBtn.Location = new System.Drawing.Point(237, 378);
            this.scoreboardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreboardBtn.Name = "scoreboardBtn";
            this.scoreboardBtn.Size = new System.Drawing.Size(461, 90);
            this.scoreboardBtn.TabIndex = 5;
            this.scoreboardBtn.Text = "Scoreboard";
            this.scoreboardBtn.UseVisualStyleBackColor = true;
            this.scoreboardBtn.Click += new System.EventHandler(this.go_to_scoreboard);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 587);
            this.Controls.Add(this.scoreboardBtn);
            this.Controls.Add(this.menuTitleLabel);
            this.Controls.Add(this.exitApplicationBtn);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.startGameBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.LocationChanged += new System.EventHandler(this.Menu_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Button exitApplicationBtn;
        private System.Windows.Forms.Label menuTitleLabel;
        private System.Windows.Forms.Button scoreboardBtn;
    }
}

