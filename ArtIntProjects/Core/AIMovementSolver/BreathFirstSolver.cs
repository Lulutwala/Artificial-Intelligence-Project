using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class BreadthFirstSolver
    {
        private List<Action> actions = new List<Action>
    {
        Action.Up, Action.Down, Action.Left, Action.Right,
        Action.UpLeft, Action.UpRight, Action.DownLeft, Action.DownRight
    };

        private HashSet<(int, int)> visited = new HashSet<(int, int)>();

        public bool Solve(ChessState initialState, out List<(Action, int, int, int)> path)
        {
            Queue<(ChessState, List<(Action, int, int, int)>, int)> queue = new Queue<(ChessState, List<(Action, int, int, int)>, int)>();
            path = new List<(Action, int, int, int)>();

            queue.Enqueue((initialState, new List<(Action, int, int, int)>(), 0));
            visited.Add((initialState.X, initialState.Y));

            while (queue.Count > 0)
            {
                var (currentState, currentPath, steps) = queue.Dequeue();

                if (currentState.IsGoalState)
                {
                    path = currentPath;
                    return true;
                }

                foreach (var action in actions)
                {
                    var clone = (ChessState)currentState.Clone();
                    if (clone.ApplyOperator(action) && !visited.Contains((clone.X, clone.Y)))
                    {
                        visited.Add((clone.X, clone.Y));
                        var newPath = new List<(Action, int, int, int)>(currentPath);
                        newPath.Add((action, steps + 1, clone.X, clone.Y));
                        queue.Enqueue((clone, newPath, steps + 1));
                    }
                }
            }

            return false;
        }
    }

}
