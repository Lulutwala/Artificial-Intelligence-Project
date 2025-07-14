using Core;

/*
 * Surround this code with a trying-method
 * 1. define the limit of tryings!
 * 2. Find a solution
 * 3. Save the found solution and it's length
 * 4. Find a new solution
 * 5. If the length of the new solution is shorter than the stored one than replace them
 * 6. If you reach the limit than stop the running and print out the result
 *    Else GOTO 4.
 */

/*
 * Solve the cabbage-goat-wolf problem!
 */

namespace DieHard3CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //DieHard3State state = new DieHard3State();
            //int step = 0;
            //while(!state.IsGoalState)
            //{
            //    if (state.ApplyOperator(rnd.NextDouble() < 0.5, (DieHard3Action)rnd.Next(3)))
            //    {
            //        step++;
            //        Console.WriteLine($"{step}. {state}");
            //    }
            //}

            //DieHard3SolverBase solver = new DieHard3BackTrack(0, true);
            DieHard3SolverBase solver = new DieHard3DepthFirst();
            Stack<DieHard3Node> solution = solver.Solution(solver.Search());

            while(solution.Count != 0)
            {
                Console.WriteLine(solution.Pop().State);
            }

            Console.ReadLine();
        }
    }
}