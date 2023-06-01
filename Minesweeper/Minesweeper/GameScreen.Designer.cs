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
            this.minesField = new System.Windows.Forms.DataGridView();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.totalBombsTextLabel = new System.Windows.Forms.Label();
            this.totalBombsCountLabel = new System.Windows.Forms.Label();
            this.totalEmptySquaresTextLabel = new System.Windows.Forms.Label();
            this.totalEmptySquaresCountLabel = new System.Windows.Forms.Label();
            this.emptySquaresLeftTextLabel = new System.Windows.Forms.Label();
            this.emptySquaresLeftCountLabel = new System.Windows.Forms.Label();
            this.scoreTextLabel = new System.Windows.Forms.Label();
            this.scoreTextCountLabel = new System.Windows.Forms.Label();
            this.gameProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.minesField)).BeginInit();
            this.SuspendLayout();
            // 
            // gameScreenToMenuBtn
            // 
            this.gameScreenToMenuBtn.Location = new System.Drawing.Point(9, 10);
            this.gameScreenToMenuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.gameScreenToMenuBtn.Name = "gameScreenToMenuBtn";
            this.gameScreenToMenuBtn.Size = new System.Drawing.Size(147, 72);
            this.gameScreenToMenuBtn.TabIndex = 0;
            this.gameScreenToMenuBtn.Text = "Menu";
            this.gameScreenToMenuBtn.UseVisualStyleBackColor = true;
            this.gameScreenToMenuBtn.Click += new System.EventHandler(this.return_to_menu_from_gamescreen);
            // 
            // minesField
            // 
            this.minesField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.minesField.Location = new System.Drawing.Point(160, 10);
            this.minesField.Margin = new System.Windows.Forms.Padding(2);
            this.minesField.Name = "minesField";
            this.minesField.RowHeadersWidth = 51;
            this.minesField.RowTemplate.Height = 24;
            this.minesField.Size = new System.Drawing.Size(712, 469);
            this.minesField.TabIndex = 1;
            this.minesField.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.cellMouseClick);
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(9, 86);
            this.newGameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(147, 72);
            this.newGameBtn.TabIndex = 2;
            this.newGameBtn.Text = "New game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // totalBombsTextLabel
            // 
            this.totalBombsTextLabel.AutoSize = true;
            this.totalBombsTextLabel.Location = new System.Drawing.Point(12, 173);
            this.totalBombsTextLabel.Name = "totalBombsTextLabel";
            this.totalBombsTextLabel.Size = new System.Drawing.Size(98, 13);
            this.totalBombsTextLabel.TabIndex = 3;
            this.totalBombsTextLabel.Text = "Total bombs count:";
            // 
            // totalBombsCountLabel
            // 
            this.totalBombsCountLabel.AutoSize = true;
            this.totalBombsCountLabel.Location = new System.Drawing.Point(121, 173);
            this.totalBombsCountLabel.Name = "totalBombsCountLabel";
            this.totalBombsCountLabel.Size = new System.Drawing.Size(13, 13);
            this.totalBombsCountLabel.TabIndex = 4;
            this.totalBombsCountLabel.Text = "..";
            // 
            // totalEmptySquaresTextLabel
            // 
            this.totalEmptySquaresTextLabel.AutoSize = true;
            this.totalEmptySquaresTextLabel.Location = new System.Drawing.Point(12, 201);
            this.totalEmptySquaresTextLabel.Name = "totalEmptySquaresTextLabel";
            this.totalEmptySquaresTextLabel.Size = new System.Drawing.Size(105, 13);
            this.totalEmptySquaresTextLabel.TabIndex = 5;
            this.totalEmptySquaresTextLabel.Text = "Total empty squares:";
            // 
            // totalEmptySquaresCountLabel
            // 
            this.totalEmptySquaresCountLabel.AutoSize = true;
            this.totalEmptySquaresCountLabel.Location = new System.Drawing.Point(121, 201);
            this.totalEmptySquaresCountLabel.Name = "totalEmptySquaresCountLabel";
            this.totalEmptySquaresCountLabel.Size = new System.Drawing.Size(13, 13);
            this.totalEmptySquaresCountLabel.TabIndex = 6;
            this.totalEmptySquaresCountLabel.Text = "..";
            // 
            // emptySquaresLeftTextLabel
            // 
            this.emptySquaresLeftTextLabel.AutoSize = true;
            this.emptySquaresLeftTextLabel.Location = new System.Drawing.Point(12, 229);
            this.emptySquaresLeftTextLabel.Name = "emptySquaresLeftTextLabel";
            this.emptySquaresLeftTextLabel.Size = new System.Drawing.Size(96, 13);
            this.emptySquaresLeftTextLabel.TabIndex = 8;
            this.emptySquaresLeftTextLabel.Text = "Empty squares left:";
            // 
            // emptySquaresLeftCountLabel
            // 
            this.emptySquaresLeftCountLabel.AutoSize = true;
            this.emptySquaresLeftCountLabel.Location = new System.Drawing.Point(121, 229);
            this.emptySquaresLeftCountLabel.Name = "emptySquaresLeftCountLabel";
            this.emptySquaresLeftCountLabel.Size = new System.Drawing.Size(13, 13);
            this.emptySquaresLeftCountLabel.TabIndex = 7;
            this.emptySquaresLeftCountLabel.Text = "..";
            // 
            // scoreTextLabel
            // 
            this.scoreTextLabel.AutoSize = true;
            this.scoreTextLabel.Location = new System.Drawing.Point(66, 280);
            this.scoreTextLabel.Name = "scoreTextLabel";
            this.scoreTextLabel.Size = new System.Drawing.Size(38, 13);
            this.scoreTextLabel.TabIndex = 9;
            this.scoreTextLabel.Text = "Score:";
            // 
            // scoreTextCountLabel
            // 
            this.scoreTextCountLabel.AutoSize = true;
            this.scoreTextCountLabel.Location = new System.Drawing.Point(66, 303);
            this.scoreTextCountLabel.Name = "scoreTextCountLabel";
            this.scoreTextCountLabel.Size = new System.Drawing.Size(13, 13);
            this.scoreTextCountLabel.TabIndex = 10;
            this.scoreTextCountLabel.Text = "..";
            // 
            // gameProgressBar
            // 
            this.gameProgressBar.Location = new System.Drawing.Point(10, 254);
            this.gameProgressBar.Name = "gameProgressBar";
            this.gameProgressBar.Size = new System.Drawing.Size(146, 23);
            this.gameProgressBar.TabIndex = 11;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.gameProgressBar);
            this.Controls.Add(this.scoreTextCountLabel);
            this.Controls.Add(this.scoreTextLabel);
            this.Controls.Add(this.emptySquaresLeftTextLabel);
            this.Controls.Add(this.emptySquaresLeftCountLabel);
            this.Controls.Add(this.totalEmptySquaresCountLabel);
            this.Controls.Add(this.totalEmptySquaresTextLabel);
            this.Controls.Add(this.totalBombsCountLabel);
            this.Controls.Add(this.totalBombsTextLabel);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.minesField);
            this.Controls.Add(this.gameScreenToMenuBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minesField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gameScreenToMenuBtn;
        private System.Windows.Forms.DataGridView minesField;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Label totalBombsTextLabel;
        private System.Windows.Forms.Label totalBombsCountLabel;
        private System.Windows.Forms.Label totalEmptySquaresTextLabel;
        private System.Windows.Forms.Label totalEmptySquaresCountLabel;
        private System.Windows.Forms.Label emptySquaresLeftTextLabel;
        private System.Windows.Forms.Label emptySquaresLeftCountLabel;
        private System.Windows.Forms.Label scoreTextLabel;
        private System.Windows.Forms.Label scoreTextCountLabel;
        private System.Windows.Forms.ProgressBar gameProgressBar;
    }
}