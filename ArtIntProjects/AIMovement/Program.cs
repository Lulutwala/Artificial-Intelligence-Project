using System;
using System.Collections.Generic;
using Core; // Import the namespace containing Backtrack and ChessState
using Action = Core.Action;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
           /* ChessState initialState = new ChessState();

            // Create an empty list to store the path
            List<(Action, int, int, int, int)> path = new List<(Action, int, int, int, int)>();

            // Create an instance of the BacktrackingSolver class
            BacktrackingSolver solver = new BacktrackingSolver();

            // Call the Solve method of the solver instance to find the solution path
            if (solver.Solve(initialState, path, 0))
            {
                // Display the result
                Console.WriteLine("Path found:");
                foreach (var (action, step, x, y, steps) in path) // Adjust tuple order to match BacktrackingSolver
                {
                    Console.WriteLine($"{step}: {action} (Steps: {steps}) -> ({x}, {y})");
                }
            }
            else
            {
                Console.WriteLine("No path found.");
            }

            // Wait for user input before exiting (optional)
            Console.ReadLine();

            // Keep the console window open


            ChessState initialState = new ChessState();
            List<(Action, int, int, int)> path = new List<(Action, int, int, int)>();

            DepthFirstSolver solver = new DepthFirstSolver();

            if (solver.Solve(initialState, path, 0))
            {
                Console.WriteLine("Path found:");
                foreach (var (action, step, x, y) in path)
                {
                    Console.WriteLine($"{step}: {action} -> ({x}, {y})");
                }
            }
            else
            {
                Console.WriteLine("No path found.");
            }

            Console.ReadLine(); // Wait for user input before closing the console
        }*/
            /*ChessState initialState = new ChessState();
            List<(Action, int, int, int)> path;

            BreadthFirstSolver solver = new BreadthFirstSolver();

            if (solver.Solve(initialState, out path))
            {
                Console.WriteLine("Path found:");
                foreach (var (action, steps, x, y) in path)
                {
                    Console.WriteLine($"{steps}: {action} -> ({x}, {y})");
                }
            }
            else
            {
                Console.WriteLine("No path found.");
            }*/

            /*ChessState initialState = new ChessState();
            OptimalSearch solver = new OptimalSearch();
            List<(Action, int, int)> path;
            int steps;

            if (solver.Solve(initialState, out path, out steps))
            {
                Console.WriteLine("Path found:");
                foreach (var (action, x, y) in path)
                {
                    Console.WriteLine($"Action: {action}, X: {x}, Y: {y}");
                }
                Console.WriteLine($"Total steps: {steps}");
            }
            else
            {
                Console.WriteLine("No path found.");
            }*/

        }

    }
}
