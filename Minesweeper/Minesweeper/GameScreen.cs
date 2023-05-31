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
            int colcount = 10;
            int rowcount = 10;
            minesField.ColumnCount = colcount;      //setting the field
            minesField.RowCount = rowcount;         //setting the field
            minesField.Width = minesField.ColumnCount * 60;     //configuring the size of the field
            minesField.Height = minesField.RowCount * 60;       //configuring the size of the field
            minesField.ColumnHeadersVisible = false;         //removing the extra stuff
            minesField.RowHeadersVisible = false;            //removing the extra stuff
            minesField.ReadOnly = true;                      //blocking unwanted midification from the user
            minesField.ScrollBars = ScrollBars.None;         //blocking unwanted midification from the user
            minesField.AllowUserToResizeRows = false;        //blocking unwanted midification from the user
            minesField.AllowUserToResizeColumns = false;     //blocking unwanted midification from the user
            minesField.DefaultCellStyle.Font = new Font("Arial", 12);       //selecting the font
            minesField.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;   //centering content of the squares
            for (int i = 0; i < colcount; i++)     //configuring the size of the field-tiles
            {
                for (int j = 0; j < rowcount; j++)
                {
                    minesField.Rows[i].Height = 60;
                    minesField.Columns[i].Width = 60;

                }
            }
            MinesMatrix minesMatrix = new MinesMatrix();
            int[,] matrix = minesMatrix.FetchMatrix(10,10,16);
            for (int i = 0; i < colcount; i++)     
            {
                for (int j = 0; j < rowcount; j++)
                {
                    minesField.Rows[i].Cells[j].Value = matrix[i, j];

                }
            }
        }
    }
}
