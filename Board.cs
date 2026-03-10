using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Of_Life
{
    public class Board
    {
        private bool[,] grid;

        public int Rows { get; set; }
        public int Columns { get; set; }

        // Constructor to initialize the board with given dimensions
        public Board(int rows, int cols)
        {
            Rows = rows;
            Columns = cols;
            grid = new bool[Rows, Columns];
        }

        // Method to print the current state of the board
        // Alive cells are represented by "O" and dead cells by "."
        public void PrintBoard()
        {
            Console.Clear();

            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    Console.Write(grid[r, c] ? "O " : ". ");
                }

                Console.WriteLine();
            }
        }

        // Method to clear the board by setting all cells to false (dead)
        public void ClearBoard()
        {
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    grid[r, c] = false;
                }
            }
        }

        // Method to set the state of a specific cell
        public void SetCell(int row, int col, bool state)
        {
            if (row >= 0 && row < Rows && col >= 0 && col < Columns)
            {
                grid[row, col] = state;
            }
        }
    }
}


