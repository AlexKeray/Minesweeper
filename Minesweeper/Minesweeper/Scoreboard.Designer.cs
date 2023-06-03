namespace Minesweeper
{
    partial class Scoreboard
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
            this.scoreboardTable = new System.Windows.Forms.DataGridView();
            this.scoreboardToMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardTable)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreboardTable
            // 
            this.scoreboardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreboardTable.Location = new System.Drawing.Point(12, 12);
            this.scoreboardTable.Name = "scoreboardTable";
            this.scoreboardTable.RowHeadersWidth = 51;
            this.scoreboardTable.RowTemplate.Height = 24;
            this.scoreboardTable.Size = new System.Drawing.Size(708, 333);
            this.scoreboardTable.TabIndex = 0;
            // 
            // scoreboardToMenuBtn
            // 
            this.scoreboardToMenuBtn.Location = new System.Drawing.Point(56, 390);
            this.scoreboardToMenuBtn.Name = "scoreboardToMenuBtn";
            this.scoreboardToMenuBtn.Size = new System.Drawing.Size(75, 23);
            this.scoreboardToMenuBtn.TabIndex = 1;
            this.scoreboardToMenuBtn.Text = "menu";
            this.scoreboardToMenuBtn.UseVisualStyleBackColor = true;
            this.scoreboardToMenuBtn.Click += new System.EventHandler(this.scoreboardToMenuBtn_Click);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreboardToMenuBtn);
            this.Controls.Add(this.scoreboardTable);
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView scoreboardTable;
        private System.Windows.Forms.Button scoreboardToMenuBtn;
    }
}