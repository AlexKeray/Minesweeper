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
            this.gameScreenToMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameScreenToMenuBtn.Location = new System.Drawing.Point(12, 584);
            this.gameScreenToMenuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameScreenToMenuBtn.Name = "gameScreenToMenuBtn";
            this.gameScreenToMenuBtn.Size = new System.Drawing.Size(196, 89);
            this.gameScreenToMenuBtn.TabIndex = 0;
            this.gameScreenToMenuBtn.Text = "Menu";
            this.gameScreenToMenuBtn.UseVisualStyleBackColor = true;
            this.gameScreenToMenuBtn.Click += new System.EventHandler(this.return_to_menu_from_gamescreen);
            // 
            // minesField
            // 
            this.minesField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.minesField.Location = new System.Drawing.Point(235, 25);
            this.minesField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minesField.Name = "minesField";
            this.minesField.RowHeadersWidth = 51;
            this.minesField.RowTemplate.Height = 24;
            this.minesField.Size = new System.Drawing.Size(790, 577);
            this.minesField.TabIndex = 1;
            this.minesField.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.cellMouseClick);
            // 
            // newGameBtn
            // 
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBtn.Location = new System.Drawing.Point(13, 491);
            this.newGameBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(196, 89);
            this.newGameBtn.TabIndex = 2;
            this.newGameBtn.Text = "New game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // totalBombsTextLabel
            // 
            this.totalBombsTextLabel.AutoSize = true;
            this.totalBombsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBombsTextLabel.Location = new System.Drawing.Point(13, 31);
            this.totalBombsTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalBombsTextLabel.Name = "totalBombsTextLabel";
            this.totalBombsTextLabel.Size = new System.Drawing.Size(136, 18);
            this.totalBombsTextLabel.TabIndex = 3;
            this.totalBombsTextLabel.Text = "Total bombs count:";
            // 
            // totalBombsCountLabel
            // 
            this.totalBombsCountLabel.AutoSize = true;
            this.totalBombsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBombsCountLabel.Location = new System.Drawing.Point(181, 31);
            this.totalBombsCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalBombsCountLabel.Name = "totalBombsCountLabel";
            this.totalBombsCountLabel.Size = new System.Drawing.Size(17, 20);
            this.totalBombsCountLabel.TabIndex = 4;
            this.totalBombsCountLabel.Text = "..";
            this.totalBombsCountLabel.Click += new System.EventHandler(this.totalBombsCountLabel_Click);
            // 
            // totalEmptySquaresTextLabel
            // 
            this.totalEmptySquaresTextLabel.AutoSize = true;
            this.totalEmptySquaresTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEmptySquaresTextLabel.Location = new System.Drawing.Point(13, 64);
            this.totalEmptySquaresTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalEmptySquaresTextLabel.Name = "totalEmptySquaresTextLabel";
            this.totalEmptySquaresTextLabel.Size = new System.Drawing.Size(146, 18);
            this.totalEmptySquaresTextLabel.TabIndex = 5;
            this.totalEmptySquaresTextLabel.Text = "Total empty squares:";
            // 
            // totalEmptySquaresCountLabel
            // 
            this.totalEmptySquaresCountLabel.AutoSize = true;
            this.totalEmptySquaresCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEmptySquaresCountLabel.Location = new System.Drawing.Point(181, 63);
            this.totalEmptySquaresCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalEmptySquaresCountLabel.Name = "totalEmptySquaresCountLabel";
            this.totalEmptySquaresCountLabel.Size = new System.Drawing.Size(17, 20);
            this.totalEmptySquaresCountLabel.TabIndex = 6;
            this.totalEmptySquaresCountLabel.Text = "..";
            this.totalEmptySquaresCountLabel.Click += new System.EventHandler(this.totalEmptySquaresCountLabel_Click);
            // 
            // emptySquaresLeftTextLabel
            // 
            this.emptySquaresLeftTextLabel.AutoSize = true;
            this.emptySquaresLeftTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptySquaresLeftTextLabel.Location = new System.Drawing.Point(13, 96);
            this.emptySquaresLeftTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emptySquaresLeftTextLabel.Name = "emptySquaresLeftTextLabel";
            this.emptySquaresLeftTextLabel.Size = new System.Drawing.Size(134, 18);
            this.emptySquaresLeftTextLabel.TabIndex = 8;
            this.emptySquaresLeftTextLabel.Text = "Empty squares left:";
            // 
            // emptySquaresLeftCountLabel
            // 
            this.emptySquaresLeftCountLabel.AutoSize = true;
            this.emptySquaresLeftCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptySquaresLeftCountLabel.Location = new System.Drawing.Point(181, 95);
            this.emptySquaresLeftCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emptySquaresLeftCountLabel.Name = "emptySquaresLeftCountLabel";
            this.emptySquaresLeftCountLabel.Size = new System.Drawing.Size(17, 20);
            this.emptySquaresLeftCountLabel.TabIndex = 7;
            this.emptySquaresLeftCountLabel.Text = "..";
            // 
            // scoreTextLabel
            // 
            this.scoreTextLabel.AutoSize = true;
            this.scoreTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextLabel.Location = new System.Drawing.Point(27, 184);
            this.scoreTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreTextLabel.Name = "scoreTextLabel";
            this.scoreTextLabel.Size = new System.Drawing.Size(96, 32);
            this.scoreTextLabel.TabIndex = 9;
            this.scoreTextLabel.Text = "Score:";
            // 
            // scoreTextCountLabel
            // 
            this.scoreTextCountLabel.AutoSize = true;
            this.scoreTextCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextCountLabel.Location = new System.Drawing.Point(128, 179);
            this.scoreTextCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreTextCountLabel.Name = "scoreTextCountLabel";
            this.scoreTextCountLabel.Size = new System.Drawing.Size(35, 39);
            this.scoreTextCountLabel.TabIndex = 10;
            this.scoreTextCountLabel.Text = "..";
            // 
            // gameProgressBar
            // 
            this.gameProgressBar.Location = new System.Drawing.Point(19, 131);
            this.gameProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.gameProgressBar.Name = "gameProgressBar";
            this.gameProgressBar.Size = new System.Drawing.Size(195, 28);
            this.gameProgressBar.TabIndex = 11;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 683);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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