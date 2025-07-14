using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core{
    public class OptimalSearch
    {
        private List<Action> actions = new List<Action>
    {
        Action.Up, Action.Down, Action.Left, Action.Right,
        Action.UpLeft, Action.UpRight, Action.DownLeft, Action.DownRight
    };

        private int Heuristic(ChessState state)
        {
            return Math.Abs(9 - state.X) + Math.Abs(6 - state.Y); // Manhattan distance to the goal (9, 6)
        }

        public bool Solve(ChessState initialState, out List<(Action, int, int)> path, out int steps)
        {
            var openSet = new PriorityQueue<ChessState>();
            var cameFrom = new Dictionary<ChessState, (ChessState, Action)>();
            var gScore = new Dictionary<ChessState, int>();
            var fScore = new Dictionary<ChessState, int>();

            path = new List<(Action, int, int)>();
            steps = 0;

            openSet.Enqueue(initialState, 0);
            gScore[initialState] = 0;
            fScore[initialState] = Heuristic(initialState);

            while (openSet.Count > 0)
            {
                var current = openSet.Dequeue();
                steps++;

                if (current.IsGoalState)
                {
                    ReconstructPath(cameFrom, current, path);
                    return true;
                }

                foreach (var action in actions)
                {
                    var neighbor = (ChessState)current.Clone();
                    if (neighbor.ApplyOperator(action))
                    {
                        int tentativeGScore = gScore[current] + 1;

                        if (!gScore.ContainsKey(neighbor) || tentativeGScore < gScore[neighbor])
                        {
                            cameFrom[neighbor] = (current, action);
                            gScore[neighbor] = tentativeGScore;
                            fScore[neighbor] = tentativeGScore + Heuristic(neighbor);

                            if (!openSet.Contains(neighbor))
                            {
                                openSet.Enqueue(neighbor, fScore[neighbor]);
                            }
                        }
                    }
                }
            }

            return false;
        }

        private void ReconstructPath(Dictionary<ChessState, (ChessState, Action)> cameFrom, ChessState current, List<(Action, int, int)> path)
        {
            var totalPath = new List<(Action, int, int)>();
            while (cameFrom.ContainsKey(current))
            {
                var (previous, action) = cameFrom[current];
                totalPath.Insert(0, (action, current.X, current.Y));
                current = previous;
            }

            path.AddRange(totalPath);
        }
    }

    public class PriorityQueue<T>
    {
        private List<(T item, int priority)> elements = new List<(T item, int priority)>();

        public int Count => elements.Count;

        public void Enqueue(T item, int priority)
        {
            elements.Add((item, priority));
            elements.Sort((x, y) => x.priority.CompareTo(y.priority));
        }

        public T Dequeue()
        {
            var bestItem = elements[0].item;
            elements.RemoveAt(0);
            return bestItem;
        }

        public bool Contains(T item)
        {
            return elements.Exists(e => e.item.Equals(item));
        }
    }

}
