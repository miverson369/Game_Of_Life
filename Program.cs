using System;

namespace Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(10, 10);

            // Example: Set some initial live cells
            board.SetCell(1, 2, true);  
            board.SetCell(2, 2, true);
            board.SetCell(3, 2, true);

            board.PrintBoard();

            Console.WriteLine("\nPress any key to clear the board...");
            Console.ReadLine();

            board.ClearBoard();
            board.PrintBoard();

            Console.WriteLine("\nBoard cleared.");
            Console.ReadLine();

        }
    }
}
