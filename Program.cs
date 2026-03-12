using System;

namespace Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the board with a specific size
            Board board = new Board(20, 20);

            // Example: Set some initial live cells
            board.SetCell(10, 9, true);
            board.SetCell(10, 10, true);
            board.SetCell(10, 11, true);

            Console.WriteLine("How many generations would you like to simulate?");
            int generations;

            while (!int.TryParse(Console.ReadLine(), out generations) || generations < 1)
            {
                Console.WriteLine("Please enter a valid number:");
            }
               

            for (int i = 0; i < generations; i++)
            {
                board.PrintBoard();
                board.NextGeneration();

                // Pause for a moment to be ablt to see the changes
                Thread.Sleep(500);
                {
                    Console.WriteLine("Simulation finished");


                    Console.Clear();
                    Console.WriteLine($"Generation {i + 1}:");
                    board.PrintBoard();
                    board.NextGeneration();
                    // Pause for a moment to visualize the changes
                    System.Threading.Thread.Sleep(500); 
                }

                board.PrintBoard();

                int neighbors = board.CountNeighbors(4, 4);

                Console.WriteLine($"\nNumber of neighbors (2, 2): {neighbors}");

                Console.WriteLine("\nPress any key to clear the board...");
                Console.ReadLine();

                board.ClearBoard();
                board.PrintBoard();

                Console.WriteLine("\nBoard cleared.");
                Console.ReadLine();

                Console.WriteLine("\nPress any key to exit...");

            }
        }
    }
}

