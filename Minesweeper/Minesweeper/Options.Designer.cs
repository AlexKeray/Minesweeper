namespace Minesweeper
{
    partial class Options
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
            this.difficultyEasyRadioButton = new System.Windows.Forms.RadioButton();
            this.difficultyMediumRadioButton = new System.Windows.Forms.RadioButton();
            this.difficultyHardRadioButton = new System.Windows.Forms.RadioButton();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // optionsToMenuBtn
            // 
            this.optionsToMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToMenuBtn.Location = new System.Drawing.Point(12, 581);
            this.optionsToMenuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionsToMenuBtn.Name = "optionsToMenuBtn";
            this.optionsToMenuBtn.Size = new System.Drawing.Size(196, 89);
            this.optionsToMenuBtn.TabIndex = 0;
            this.optionsToMenuBtn.Text = "Menu";
            this.optionsToMenuBtn.UseVisualStyleBackColor = true;
            this.optionsToMenuBtn.Click += new System.EventHandler(this.close_Options);
            // 
            // difficultyEasyRadioButton
            // 
            this.difficultyEasyRadioButton.AutoCheck = false;
            this.difficultyEasyRadioButton.AutoSize = true;
            this.difficultyEasyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyEasyRadioButton.Location = new System.Drawing.Point(439, 222);
            this.difficultyEasyRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.difficultyEasyRadioButton.Name = "difficultyEasyRadioButton";
            this.difficultyEasyRadioButton.Size = new System.Drawing.Size(77, 29);
            this.difficultyEasyRadioButton.TabIndex = 1;
            this.difficultyEasyRadioButton.TabStop = true;
            this.difficultyEasyRadioButton.Text = "Easy";
            this.difficultyEasyRadioButton.UseVisualStyleBackColor = true;
            this.difficultyEasyRadioButton.Click += new System.EventHandler(this.click_difficultyEasyRadioButton);
            // 
            // difficultyMediumRadioButton
            // 
            this.difficultyMediumRadioButton.AutoCheck = false;
            this.difficultyMediumRadioButton.AutoSize = true;
            this.difficultyMediumRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyMediumRadioButton.Location = new System.Drawing.Point(439, 270);
            this.difficultyMediumRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.difficultyMediumRadioButton.Name = "difficultyMediumRadioButton";
            this.difficultyMediumRadioButton.Size = new System.Drawing.Size(103, 29);
            this.difficultyMediumRadioButton.TabIndex = 2;
            this.difficultyMediumRadioButton.TabStop = true;
            this.difficultyMediumRadioButton.Text = "Medium";
            this.difficultyMediumRadioButton.UseVisualStyleBackColor = true;
            this.difficultyMediumRadioButton.Click += new System.EventHandler(this.click_difficultyMediumRadioButton);
            // 
            // difficultyHardRadioButton
            // 
            this.difficultyHardRadioButton.AutoCheck = false;
            this.difficultyHardRadioButton.AutoSize = true;
            this.difficultyHardRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyHardRadioButton.Location = new System.Drawing.Point(439, 321);
            this.difficultyHardRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.difficultyHardRadioButton.Name = "difficultyHardRadioButton";
            this.difficultyHardRadioButton.Size = new System.Drawing.Size(75, 29);
            this.difficultyHardRadioButton.TabIndex = 3;
            this.difficultyHardRadioButton.TabStop = true;
            this.difficultyHardRadioButton.Text = "Hard";
            this.difficultyHardRadioButton.UseVisualStyleBackColor = true;
            this.difficultyHardRadioButton.Click += new System.EventHandler(this.click_difficultyHardRadioButton);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.Location = new System.Drawing.Point(420, 162);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(131, 32);
            this.difficultyLabel.TabIndex = 4;
            this.difficultyLabel.Text = "Difficulty:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(280, 412);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(152, 32);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.Location = new System.Drawing.Point(454, 409);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(218, 38);
            this.usernameTextbox.TabIndex = 6;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 658);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.difficultyHardRadioButton);
            this.Controls.Add(this.difficultyMediumRadioButton);
            this.Controls.Add(this.difficultyEasyRadioButton);
            this.Controls.Add(this.optionsToMenuBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.load_options);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button optionsToMenuBtn;
        private System.Windows.Forms.RadioButton difficultyEasyRadioButton;
        private System.Windows.Forms.RadioButton difficultyMediumRadioButton;
        private System.Windows.Forms.RadioButton difficultyHardRadioButton;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
    }
}