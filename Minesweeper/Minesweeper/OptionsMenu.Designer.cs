namespace Minesweeper
{
    partial class OptionsMenu
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
            this.optionsToMenuBtn = new System.Windows.Forms.Button();
            this.difficultyEasy = new System.Windows.Forms.RadioButton();
            this.difficultyMedium = new System.Windows.Forms.RadioButton();
            this.difficultyHard = new System.Windows.Forms.RadioButton();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // optionsToMenuBtn
            // 
            this.optionsToMenuBtn.Location = new System.Drawing.Point(689, 514);
            this.optionsToMenuBtn.Name = "optionsToMenuBtn";
            this.optionsToMenuBtn.Size = new System.Drawing.Size(245, 88);
            this.optionsToMenuBtn.TabIndex = 0;
            this.optionsToMenuBtn.Text = "Menu";
            this.optionsToMenuBtn.UseVisualStyleBackColor = true;
            this.optionsToMenuBtn.Click += new System.EventHandler(this.return_to_menu_from_options);
            // 
            // difficultyEasy
            // 
            this.difficultyEasy.AutoCheck = false;
            this.difficultyEasy.AutoSize = true;
            this.difficultyEasy.Location = new System.Drawing.Point(774, 284);
            this.difficultyEasy.Name = "difficultyEasy";
            this.difficultyEasy.Size = new System.Drawing.Size(59, 20);
            this.difficultyEasy.TabIndex = 1;
            this.difficultyEasy.TabStop = true;
            this.difficultyEasy.Text = "Easy";
            this.difficultyEasy.UseVisualStyleBackColor = true;
            this.difficultyEasy.Click += new System.EventHandler(this.click_difficultyEasy_radioBtn);
            // 
            // difficultyMedium
            // 
            this.difficultyMedium.AutoCheck = false;
            this.difficultyMedium.AutoSize = true;
            this.difficultyMedium.Location = new System.Drawing.Point(774, 322);
            this.difficultyMedium.Name = "difficultyMedium";
            this.difficultyMedium.Size = new System.Drawing.Size(76, 20);
            this.difficultyMedium.TabIndex = 2;
            this.difficultyMedium.TabStop = true;
            this.difficultyMedium.Text = "Medium";
            this.difficultyMedium.UseVisualStyleBackColor = true;
            this.difficultyMedium.Click += new System.EventHandler(this.click_difficultyMedium_radioBtn);
            // 
            // difficultyHard
            // 
            this.difficultyHard.AutoCheck = false;
            this.difficultyHard.AutoSize = true;
            this.difficultyHard.Location = new System.Drawing.Point(774, 361);
            this.difficultyHard.Name = "difficultyHard";
            this.difficultyHard.Size = new System.Drawing.Size(58, 20);
            this.difficultyHard.TabIndex = 3;
            this.difficultyHard.TabStop = true;
            this.difficultyHard.Text = "Hard";
            this.difficultyHard.UseVisualStyleBackColor = true;
            this.difficultyHard.Click += new System.EventHandler(this.click_difficultyHard_radioBtn);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(771, 245);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(59, 16);
            this.difficultyLabel.TabIndex = 4;
            this.difficultyLabel.Text = "Difficulty:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(717, 437);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 16);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(811, 437);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 22);
            this.usernameTextbox.TabIndex = 6;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.change_username);
            // 
            // OptionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.difficultyHard);
            this.Controls.Add(this.difficultyMedium);
            this.Controls.Add(this.difficultyEasy);
            this.Controls.Add(this.optionsToMenuBtn);
            this.Name = "OptionsMenu";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button optionsToMenuBtn;
        private System.Windows.Forms.RadioButton difficultyEasy;
        private System.Windows.Forms.RadioButton difficultyMedium;
        private System.Windows.Forms.RadioButton difficultyHard;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
    }
}