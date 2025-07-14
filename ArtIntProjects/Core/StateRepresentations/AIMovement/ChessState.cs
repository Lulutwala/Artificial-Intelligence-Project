using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Core
{
    public class ChessState : State, IOperatorHandler<Action>
    {
        int x = 0;
        int y = 0;

        public int[,] Chess = {
        { 1, 5, 3, 4, 3, 6, 7, 1, 1, 6 },
        { 4, 4, 3, 4, 2, 6, 2, 6, 2, 5 },
        { 1, 3, 9, 4, 5, 2, 4, 2, 9, 5 },
        { 5, 2, 3, 5, 5, 6, 4, 6, 2, 4 },
        { 1, 3, 3, 2, 5, 6, 5, 2, 3, 2 },
        { 2, 5, 2, 5, 5, 6, 4, 8, 6, 1 },
        { 9, 2, 3, 6, 5, 6, 2, 2, 2, 0 }
         };

        public override bool IsState
        {
            get
            {
                return x >= 0 && x < Chess.GetLength(1) && y >= 0 && y < Chess.GetLength(0);
            }
        }

        public override bool IsGoalState
        {
            get
            {
                return x == 9 && y == 6;
            }
        }

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public bool ApplyOperator(Action action)
        {
            int steps = Chess[y, x];
            int newX = x, newY = y;

            switch (action)
            {
                case Action.Up:
                    newY -= steps;
                    break;
                case Action.Down:
                    newY += steps;
                    break;
                case Action.Left:
                    newX -= steps;
                    break;
                case Action.Right:
                    newX += steps;
                    break;
                case Action.UpLeft:
                    newX -= steps;
                    newY -= steps;
                    break;
                case Action.UpRight:
                    newX += steps;
                    newY -= steps;
                    break;
                case Action.DownLeft:
                    newX -= steps;
                    newY += steps;
                    break;
                case Action.DownRight:
                    newX += steps;
                    newY += steps;
                    break;
                default:
                    return false;
            }

            if (newX >= 0 && newX < Chess.GetLength(1) && newY >= 0 && newY < Chess.GetLength(0))
            {
                x = newX;
                y = newY;
                return true;
            }

            return false;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool IsOperator(Action action)
        {
            return true;
        }

        public override string ToString()
        {
            return $"Current position: ({x}, {y})";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ChessState otherState = (ChessState)obj;
            return this.x == otherState.x && this.y == otherState.y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }
    }

}