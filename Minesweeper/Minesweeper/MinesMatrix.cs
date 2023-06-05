using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class MinesMatrix
    {
        private int[,] matrix; // This is the matrix that powers the minesField

        public int[,] FetchMatrix(int rows, int cols, int mines_qty)
        {
            InitializeMatrix(rows, cols); // Fills the matrx with 0, which represent empty cell in the minesField
            PlantMines(mines_qty);
            FillEmptyCells(); // Iterates trough every empty cell and checks how many adjacent bombs are there.
            return matrix;
        }
        private void InitializeMatrix(int rows, int cols)
        {
            matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = 0;
                }
            }

        }

        private void PlantMines(int mines_qty)
        {
            int rows = matrix.GetLength(0); // FInding the limits of the matrix
            int cols = matrix.GetLength(1); // FInding the limits of the matrix

            Random random = new Random();

            int mine_x;     // random coordinate of the bomb
            int mine_y;  // random coordinate of the bomb

            for (int i = 0; i < mines_qty; i++)
            {
                mine_x = random.Next(0, rows);
                mine_y = random.Next(0, cols);
                if (matrix[mine_x, mine_y] != 0) //this is to escape the case when 
                {                                // the random bomb is placed over another bomb
                    i--;        //this makes the loop to do this iteration again, not to skip it
                    continue;
                }
                else
                {
                    matrix[mine_x, mine_y] = 9;  //placing the BOMB
                }
            }
        }

        private void FillEmptyCells()
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int adjacent_bomb_counter;

            for (int i = 0; i < rows; i++)     
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 9)  //the bomb square doesnt need to change its value
                    { continue; }
                        
                    if (i == 0)     // checks if the adjacent cells are within the limits of the matrix
                    {
                        if (j == 0)
                        {
                            adjacent_bomb_counter = 0;
                            if (matrix[1, 0] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[0, 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[1, 1] == 9)
                            { adjacent_bomb_counter++; }
                            matrix[i, j] += adjacent_bomb_counter;
                        }
                        else if (j == cols-1)
                        {
                            adjacent_bomb_counter = 0;
                            if (matrix[0, cols-2] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[1, cols-1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[1, cols-2] == 9)
                            { adjacent_bomb_counter++; }
                            matrix[i, j] += adjacent_bomb_counter;
                        }
                        else
                        {
                            adjacent_bomb_counter = 0;
                            if (matrix[0, j - 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[0, j + 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[1, j - 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[1, j] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[1, j + 1] == 9)
                            { adjacent_bomb_counter++; }
                            matrix[i, j] += adjacent_bomb_counter;
                        }
                    }

                    else if (i == rows-1)
                    {
                        if (j == 0)
                        {
                            adjacent_bomb_counter = 0;
                            if (matrix[rows-2, 0] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[rows-1, 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[rows-2, 1] == 9)
                            { adjacent_bomb_counter++; }
                            matrix[i, j] += adjacent_bomb_counter;
                        }
                        else if (j == cols-1)
                        {
                            adjacent_bomb_counter = 0;
                            if (matrix[rows-2, cols-1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[rows-1, cols-2] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[rows-2, cols-2] == 9)
                            { adjacent_bomb_counter++; }
                            matrix[i, j] += adjacent_bomb_counter;
                        }
                        else
                        {
                            adjacent_bomb_counter = 0;
                            if (matrix[rows-1, j - 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[rows - 1, j + 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[rows - 2, j] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[rows - 2, j - 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[rows - 2, j + 1] == 9)
                            { adjacent_bomb_counter++; }
                            matrix[i, j] += adjacent_bomb_counter;
                        }
                    }

                    else
                    {
                        if (j == 0)
                        {
                            adjacent_bomb_counter = 0;
                            if (matrix[i - 1, 0] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i + 1, 0] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i, 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i - 1, 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i + 1, 1] == 9)
                            { adjacent_bomb_counter++; }
                            matrix[i, j] += adjacent_bomb_counter;
                        }
                        else if (j == cols-1)
                        {
                            adjacent_bomb_counter = 0;
                            if (matrix[i - 1, cols-1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i + 1, cols-1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i, cols-2] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i - 1, cols-2] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i + 1, cols-2] == 9)
                            { adjacent_bomb_counter++; }
                            matrix[i, j] += adjacent_bomb_counter;
                        }
                        else
                        {
                            adjacent_bomb_counter = 0;
                            if (matrix[i - 1, j - 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i - 1, j] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i - 1, j + 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i, j - 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i, j + 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i + 1, j - 1] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i + 1, j] == 9)
                            { adjacent_bomb_counter++; }
                            if (matrix[i + 1, j + 1] == 9)
                            { adjacent_bomb_counter++; }
                            matrix[i, j] += adjacent_bomb_counter;
                        }
                    }

                }
            }
        }

    }
}
