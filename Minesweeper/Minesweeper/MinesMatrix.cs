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
        private int[,] matrix;

        public int[,] FetchMatrix(int rows, int cols, int mines_qty)
        {
            InitializeMatrix(rows, cols);
            PlantMines(mines_qty);
            FillEmptyCells();
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
            // Modify the matrix here
            // Example: Set all elements to 1
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            Random random = new Random();
            int mine_x;     //random index of a new bomb
            int mine_y;  //random index of a new bomb

            for (int i = 0; i < mines_qty; i++)
            {
                mine_x = random.Next(0, rows);
                mine_y = random.Next(0, cols);
                if (matrix[mine_x, mine_y] != 0) //this is to escape the case when 
                {                                                 //the random bomb is placed over another bomb
                    i--;    //this makes the loop to do this iteration again, not to skip it
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

            for (int i = 0; i < rows; i++)     //iterating trough every element of the matrix
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 9)  //the bomb square doesnt need to change its value
                    { continue; }
                        
                                    //there are case when the tile is at the border, so to not exeed the matrix
                                    //some of the if-s are hard-coded, if a tile is in the middle, then all 8
                                    //surrounding tiles are checked for bombs
                    if (i == 0)     
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
