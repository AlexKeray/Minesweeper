using System;

using System.Drawing;

using System.Windows.Forms;


namespace Minesweeper
{
    public partial class GameScreen : Form
    {
        int bombs_count = 0;
        int blank_cells_count = 0;
        int progressPoints = 0;
        int score = 0;
        public static int[,] matrix;
        Font chosenFont;


        public GameScreen()
        {
            InitializeComponent();
        }

        private void close_Gamescreen(object sender, EventArgs e)
        {
            this.Close();
        }
        private void start_new_game(object sender, EventArgs e)
        {
            minesField.Enabled = true;
            loadGame();
        }

        private void load_GameScreen(object sender, EventArgs e)
        {
            configure_Gamescreen_settings();
            OptionsFileHandler.read_OptionsFile_and_initialise_difficulty_and_username(@"OptionsFile.txt"); // The difficulty is needed to configure most of the following settings.
            configureGameScreenSize();
            implementDifficulty();  // Configures how many columns and rows shoud the minesField have. Also sets the right amount of mines.
            configure_cellSize_and_minesFieldSize();
            configure_minesField_settings();
            configure_bomb_font();

            loadGame(); // Prepares freshly new matrix to power the minesField. Resets the score and launch the gameInfo preparation.
        }

        private void configure_Gamescreen_settings()
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = ColorTranslator.FromHtml("#d9d9d9");
        }
        private void configureGameScreenSize()
        {
            if (Options.difficulty == "easy")
            {
                this.Size = new Size(724, 592);
            }
            else if (Options.difficulty == "medium")
            {
                this.Size = new Size(724, 592);

            }
            else if (Options.difficulty == "hard")
            {
                this.Size = new Size(1172, 592);
            }
        }
        private void implementDifficulty()  // Configures how many columns and rows shoud the minesField have. Also sets the right amount of mines.
        {
            int colcount = 10;
            int rowcount = 10;
            if (Options.difficulty == "easy")
            {
                colcount = 10;
                rowcount = 10;
                bombs_count = 10;
                blank_cells_count = 90;
            }
            else if (Options.difficulty == "medium")
            {
                colcount = 16;
                rowcount = 16;
                bombs_count = 40;
                blank_cells_count = 216;

            }
            else if (Options.difficulty == "hard")
            {
                colcount = 30;
                rowcount = 16;
                bombs_count = 99;
                blank_cells_count = 381;
            }
            minesField.ColumnCount = colcount;
            minesField.RowCount = rowcount;
        }
        private void configure_cellSize_and_minesFieldSize()
        {
            int cellSize = 0;
            if (Options.difficulty == "easy")
            {
                cellSize = 51;
            }
            else if (Options.difficulty == "medium")
            {
                cellSize = 32;
            }
            else if (Options.difficulty == "hard")
            {
                cellSize = 32;
            }

            minesField.Width = minesField.ColumnCount * cellSize;
            minesField.Height = minesField.RowCount * cellSize;

            for (int i = 0; i < minesField.RowCount; i++)
            {
                for (int j = 0; j < minesField.ColumnCount; j++)
                {
                    minesField.Rows[i].Height = cellSize;
                    minesField.Columns[j].Width = cellSize;
                }
            }

        }
        private void configure_minesField_settings() // those are the estetics settings
        {
            minesField.ColumnHeadersVisible = false;
            minesField.RowHeadersVisible = false;
            minesField.ReadOnly = true;
            minesField.ScrollBars = ScrollBars.None;
            minesField.AllowUserToResizeRows = false;
            minesField.AllowUserToResizeColumns = false;
            if (Options.difficulty == "easy")
            {
                minesField.DefaultCellStyle.Font = new Font("Arial", 18);

            }
            else if (Options.difficulty == "medium")
            {
                minesField.DefaultCellStyle.Font = new Font("Arial", 12);


            }
            else if (Options.difficulty == "hard")
            {
                minesField.DefaultCellStyle.Font = new Font("Arial", 12);

            }
            minesField.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            minesField.Enabled = true;
        }
        private void configure_bomb_font()
        {
            if (Options.difficulty == "easy")
            {
                chosenFont = new Font("Wingdings", 22);
            }
            else if (Options.difficulty == "medium")
            {
                chosenFont = new Font("Wingdings", 14);
            }
            else if (Options.difficulty == "hard")
            {
                chosenFont = new Font("Wingdings", 14);
            }
        }

        private void loadGame() // Prepares freshly new matrix to power the minesField. Resets the score and launch the gameInfo preparation.
        {
            prepare_gameInfo();
            score = 0;
            scoreTextCountLabel.Text = score.ToString();
            nullify_minesField();
            
            MinesMatrix minesMatrix = new MinesMatrix();
            matrix = minesMatrix.FetchMatrix(minesField.RowCount, minesField.ColumnCount, bombs_count);
        }

        private void prepare_gameInfo() // Prepares the informaion about the current game, which stays in the top left corner of the GameScreen
        {
            gameProgressBar.Value = 0;
            if (Options.difficulty == "easy")
            {
                totalBombsCountLabel.Text = 10.ToString();
                totalEmptySquaresCountLabel.Text = 90.ToString();
                emptySquaresLeftCountLabel.Text = blank_cells_count.ToString();
            }
            else if (Options.difficulty == "medium")
            {
                totalBombsCountLabel.Text = 40.ToString();
                totalEmptySquaresCountLabel.Text = 216.ToString();
                emptySquaresLeftCountLabel.Text = blank_cells_count.ToString();
            }
            else if (Options.difficulty == "hard")
            {
                totalBombsCountLabel.Text = 99.ToString();
                totalEmptySquaresCountLabel.Text = 381.ToString();
                emptySquaresLeftCountLabel.Text = blank_cells_count.ToString();
            }

        }

        private void nullify_minesField() // Sets the cells value to null, the color to white and the font to the numbers font ( because some cells have the bomb font from the previous game)
        {
            for (int i = 0; i < minesField.RowCount; i++)
            {
                for (int j = 0; j < minesField.ColumnCount; j++)
                {
                    minesField.Rows[i].Cells[j].Value = null;
                    minesField.Rows[i].Cells[j].Style.BackColor = Color.White;
                    if (Options.difficulty == "easy")
                    {
                        minesField.Rows[i].Cells[j].Style.Font = new Font("Arial", 18);  
                    }
                    else if (Options.difficulty == "medium")
                    {
                        minesField.Rows[i].Cells[j].Style.Font = new Font("Arial", 12); 
                    }
                    else if (Options.difficulty == "hard")
                    {
                        minesField.Rows[i].Cells[j].Style.Font = new Font("Arial", 12);       
                    }
                }
            }
        }

        private void cellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Check if left mouse button is pressed
            {
                if (minesField[e.ColumnIndex, e.RowIndex].Value == null)
                {
                    if(matrix[e.RowIndex, e.ColumnIndex] == 9)
                    {
                        
                        minesField[e.ColumnIndex, e.RowIndex].Style.Font = chosenFont;
                        minesField[e.ColumnIndex, e.RowIndex].Value = "M";
                        end_game();
                    }
                    else
                    {
                        minesField[e.ColumnIndex, e.RowIndex].Value = matrix[e.RowIndex, e.ColumnIndex];
                        evaluate_progress();
                    }
                    if (minesField[e.ColumnIndex, e.RowIndex].Style.BackColor == Color.LightSalmon)
                    {
                        minesField[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                    }
                }
            }

            if (e.Button == MouseButtons.Right) // Check if right mouse button is pressed
            {
                if (minesField[e.ColumnIndex, e.RowIndex].Value == null)
                {
                    if (minesField[e.ColumnIndex, e.RowIndex].Style.BackColor == Color.LightSalmon)
                    {
                        minesField[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                    }
                    else
                    {
                        minesField[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.LightSalmon;
                    }
                }
            }
        }

        private void evaluate_progress() // The progress changes with every cell click.
        {
            blank_cells_count--;
            score += 10;
            progressPoints++;
            if (Options.difficulty == "hard")
            {

                if (progressPoints == 4)
                {
                    gameProgressBar.Value += 1;
                    progressPoints = 0;
                }
            }
            if ((Options.difficulty == "medium") && (gameProgressBar.Value <= 100))
            {
                if (progressPoints == 2)
                {
                    gameProgressBar.Value += 1;
                    progressPoints = 0;
                }
            }
            if (Options.difficulty == "easy")
            {
                gameProgressBar.Value += 1;
            }

            emptySquaresLeftCountLabel.Text = blank_cells_count.ToString();
            scoreTextCountLabel.Text = score.ToString();

            if (blank_cells_count == 0)
            {
                gameProgressBar.Value = 100;
                end_game();
            }
        }

        private void end_game()
        {
            if(blank_cells_count == 0)
            {
                MessageBox.Show("You win!", "Congratulations!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("You loose!", "Bad luck!", MessageBoxButtons.OK);
            }

            minesField.Enabled = false;
            solve_minesField();

            ScoreboardDataBaseManager.writeScoreboardDB(score, DateTime.Now.ToString("HH:mm   d-M-yyyy"));
        }

        

        private void solve_minesField() // At the end the app shows the user where the bombs were
        {
            for (int i = 0; i < minesField.Rows.Count; i++)
            {
                for (int j = 0; j < minesField.Columns.Count; j++)
                {
                    if (minesField.Rows[i].Cells[j].Value == null)
                    {
                        minesField.Rows[i].Cells[j].Style.BackColor = Color.LightSalmon;
                    }
                    else
                    {
                        minesField.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                    }
                    if (minesField.Rows[i].Cells[j].Value == null)
                    {
                        if (matrix[i,j] == 9)
                        {
                            minesField.Rows[i].Cells[j].Style.Font = chosenFont;
                            minesField.Rows[i].Cells[j].Value = "M";

                        }
                        else
                        {
                            minesField.Rows[i].Cells[j].Value = matrix[i, j];
                        }
                    }
                }
            }
        }

        

        
    }
}
