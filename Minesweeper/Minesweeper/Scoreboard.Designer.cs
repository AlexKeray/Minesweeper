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
            this.scoreboardToMenuBtn = new System.Windows.Forms.Button();
            this.scoreboardTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardTable)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreboardToMenuBtn
            // 
            this.scoreboardToMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardToMenuBtn.Location = new System.Drawing.Point(13, 580);
            this.scoreboardToMenuBtn.Name = "scoreboardToMenuBtn";
            this.scoreboardToMenuBtn.Size = new System.Drawing.Size(196, 89);
            this.scoreboardToMenuBtn.TabIndex = 0;
            this.scoreboardToMenuBtn.Text = "menu";
            this.scoreboardToMenuBtn.UseVisualStyleBackColor = true;
            this.scoreboardToMenuBtn.Click += new System.EventHandler(this.return_to_menu_from_scoreboard);
            // 
            // scoreboardTable
            // 
            this.scoreboardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreboardTable.Location = new System.Drawing.Point(13, 12);
            this.scoreboardTable.Name = "scoreboardTable";
            this.scoreboardTable.RowHeadersWidth = 51;
            this.scoreboardTable.RowTemplate.Height = 24;
            this.scoreboardTable.Size = new System.Drawing.Size(917, 551);
            this.scoreboardTable.TabIndex = 1;
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 637);
            this.Controls.Add(this.scoreboardTable);
            this.Controls.Add(this.scoreboardToMenuBtn);
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scoreboardToMenuBtn;
        private System.Windows.Forms.DataGridView scoreboardTable;
    }
}