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
            this.SuspendLayout();
            // 
            // optionsToMenuBtn
            // 
            this.optionsToMenuBtn.Location = new System.Drawing.Point(12, 12);
            this.optionsToMenuBtn.Name = "optionsToMenuBtn";
            this.optionsToMenuBtn.Size = new System.Drawing.Size(245, 88);
            this.optionsToMenuBtn.TabIndex = 0;
            this.optionsToMenuBtn.Text = "Menu";
            this.optionsToMenuBtn.UseVisualStyleBackColor = true;
            this.optionsToMenuBtn.Click += new System.EventHandler(this.return_to_menu_from_options);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.optionsToMenuBtn);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button optionsToMenuBtn;
    }
}