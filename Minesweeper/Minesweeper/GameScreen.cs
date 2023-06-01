using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace Minesweeper
{
    public partial class GameScreen : Form
    {
        int bombs_count = 0;
        int blank_cells_count = 0;
        public static int[,] matrix;
        Font chosenFont;
        

        public GameScreen()
        {
            InitializeComponent();
        }

        private void return_to_menu_from_gamescreen(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

            OptionsFileHandler.ReadTextFile(@"OptionsFile.txt");
            implementDifficulty();
            chooseCellSize();
            chooseFont();
            minesFieldFormatSettings();
            

            
            MinesMatrix minesMatrix = new MinesMatrix();
            matrix = minesMatrix.FetchMatrix(minesField.RowCount, minesField.ColumnCount, bombs_count);

            nullifyMinesField();
            
        }

        private void nullifyMinesField()
        {
            for (int i = 0; i < minesField.RowCount; i++)
            {
                for (int j = 0; j < minesField.ColumnCount; j++)
                {
                    minesField.Rows[i].Cells[j].Value = null;

                }
            }
        }


        private void implementDifficulty()
        {
            int colcount = 10;
            int rowcount = 10;
            if (OptionsFileHandler.difficulty == "easy")
            {
                colcount = 10;
                rowcount = 10;
                bombs_count = 10;
                blank_cells_count = 90;
            }
            else if (OptionsFileHandler.difficulty == "medium")
            {
                colcount = 16;
                rowcount = 16;
                bombs_count = 40;
                blank_cells_count = 216;
                
            }
            else if (OptionsFileHandler.difficulty == "hard")
            {
                colcount = 30;
                rowcount = 16;
                bombs_count = 99;
                blank_cells_count = 381;
            }
            minesField.ColumnCount = colcount;      //setting the field
            minesField.RowCount = rowcount;         //setting the field
        }
        private void chooseCellSize()
        {
            int cellSize = 0;
            if (OptionsFileHandler.difficulty == "easy")
            {
                cellSize = 66;
            }
            else if (OptionsFileHandler.difficulty == "medium")
            {
                cellSize = 42;

            }
            else if (OptionsFileHandler.difficulty == "hard")
            {
                cellSize = 33;

            }

            for (int i = 0; i < minesField.RowCount; i++)     //configuring the size of the field-tiles
            {
                for (int j = 0; j < minesField.ColumnCount; j++)
                {
                    minesField.Rows[i].Height = cellSize;
                    minesField.Columns[j].Width = cellSize;

                }
            }
            minesField.Width = minesField.ColumnCount * cellSize;     //configuring the size of the field
            minesField.Height = minesField.RowCount * cellSize;
        }

        private void minesFieldFormatSettings()
        {
            minesField.ColumnHeadersVisible = false;         //removing the extra stuff
            minesField.RowHeadersVisible = false;            //removing the extra stuff
            minesField.ReadOnly = true;                      //blocking unwanted midification from the user
            minesField.ScrollBars = ScrollBars.None;         //blocking unwanted midification from the user
            minesField.AllowUserToResizeRows = false;        //blocking unwanted midification from the user
            minesField.AllowUserToResizeColumns = false;     //blocking unwanted midification from the user
            minesField.DefaultCellStyle.Font = new Font("Arial", 12);       //selecting the font
            minesField.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;   //centering content of the squares
            minesField.Enabled = true;
        }

        

       
        private void minesField_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Check if right mouse button is pressed
            {
                if (minesField[e.ColumnIndex, e.RowIndex].Value == null)
                {
                    if(matrix[e.RowIndex, e.ColumnIndex] == 9)
                    {
                        
                        minesField[e.ColumnIndex, e.RowIndex].Style.Font = chosenFont;
                        minesField[e.ColumnIndex, e.RowIndex].Value = "M";
                        endGame();
                    }
                    else
                    {
                        minesField[e.ColumnIndex, e.RowIndex].Value = matrix[e.RowIndex, e.ColumnIndex];
                        blank_cells_count--;
                        if(blank_cells_count == 0)
                        {
                            endGame();
                        }
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

        private void chooseFont()
        {
            if (OptionsFileHandler.difficulty == "easy")
            {
                chosenFont = new Font("Wingdings", 30);
            }
            else if (OptionsFileHandler.difficulty == "medium")
            {
                chosenFont = new Font("Wingdings", 20);
            }
            else if (OptionsFileHandler.difficulty == "hard")
            {
                chosenFont = new Font("Wingdings", 10);
            }
        }

        private void endGame()
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
