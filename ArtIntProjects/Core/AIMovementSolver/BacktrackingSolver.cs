using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class BacktrackingSolver
    {
        private List<Action> actions = new List<Action>
        {
            Action.Up, Action.Down, Action.Left, Action.Right,
            Action.UpLeft, Action.UpRight, Action.DownLeft, Action.DownRight
        };

        private HashSet<(int, int)> visited = new HashSet<(int, int)>();

        public bool Solve(ChessState state, List<(Action, int, int, int)> path, int steps)
        {
            if (state.IsGoalState)
            {
                return true;
            }

            foreach (var action in actions)
            {
                var clone = (ChessState)state.Clone();
                int originalX = clone.X;
                int originalY = clone.Y;

                if (clone.ApplyOperator(action) && !visited.Contains((clone.X, clone.Y)))
                {
                    visited.Add((clone.X, clone.Y));
                    path.Add((action, steps + 1, clone.X, clone.Y));

                    if (Solve(clone, path, steps + 1))
                    {
                        return true;
                    }

                    // Undo the action if it didn't lead to the goal state
                    clone.X = originalX;
                    clone.Y = originalY;
                    path.RemoveAt(path.Count - 1);
                    visited.Remove((clone.X, clone.Y));
                }
            }

            return false;
            }
    }
}
