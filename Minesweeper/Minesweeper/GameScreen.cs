using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class GameScreen : Form
    {
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
            implementDifficulty();
            chooseCellSize(30);
            minesFieldFormatSettings();
            

                 //configuring the size of the field

            
            
            MinesMatrix minesMatrix = new MinesMatrix();
            int[,] matrix = minesMatrix.FetchMatrix(minesField.RowCount, minesField.ColumnCount, 16);
            for (int i = 0; i < minesField.RowCount; i++)     
            {
                for (int j = 0; j < minesField.ColumnCount; j++)
                {
                    minesField.Rows[i].Cells[j].Value = matrix[i, j];

                }
            }
        }

        private void implementDifficulty()
        {
            int colcount = 10;
            int rowcount = 10;
            int bombs_count = 10;
            if (OptionsFileHandler.difficulty == "easy")
            {
                colcount = 10;
                rowcount = 10;
                bombs_count = 10;
            }
            else if (OptionsFileHandler.difficulty == "medium")
            {
                colcount = 16;
                rowcount = 16;
                bombs_count = 40;
            }
            else if (OptionsFileHandler.difficulty == "hard")
            {
                colcount = 30;
                rowcount = 16;
                bombs_count = 99;
            }
            minesField.ColumnCount = colcount;      //setting the field
            minesField.RowCount = rowcount;         //setting the field
        }
        private void chooseCellSize(int size)
        {
            int cellSize = size;
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
        }
    }
}
