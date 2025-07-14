using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class FlagState : State, IOperatorHandler<int, int, Direction>
    {
        private char[,] flag = {
            { 'G', 'G', 'G' },
            { 'E', 'W', 'E' },
            { 'W', 'W', 'E' },
            { 'E', 'W', 'E' },
            { 'R', 'R', 'R' },
        };
        public char[,] Flag
        {
            get
            {
                char[,] temp = new char[5, 3];
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        temp[i, j] = flag[i, j];
                    }
                }
                return temp;
            }
        }

        private char[,] mirroredFlag = {
            { 'R', 'R', 'R' },
            { 'E', 'W', 'E' },
            { 'W', 'W', 'E' },
            { 'E', 'W', 'E' },
            { 'G', 'G', 'G' },
        };

        public override bool IsState
        {
            get
            {
                IEnumerable<char> flagCast = flag.Cast<char>();
                return flagCast.AsParallel().Count(c => c == 'R') == 3 &&
                       flagCast.AsParallel().Count(c => c == 'G') == 3 &&
                       flagCast.AsParallel().Count(c => c == 'W') == 4 &&
                       flagCast.AsParallel().Count(c => c == 'E') == 5;
            }
        }

        public override bool IsGoalState
        {
            get
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (flag[i, j] != mirroredFlag[i, j])
                            return false;
                    }
                }
                return true;
            }
        }

        public override object Clone()
        {
            FlagState clone = new FlagState();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    clone.flag[i, j] = this.flag[i, j];
                }
            }
            return clone;
        }

        public bool ApplyOperator(int x, int y, Direction direction)
        {
            if (!IsOperator(x, y, direction))
                return false;

            FlagState clone = (FlagState)this.Clone();

            int nx = -1, ny = -1;
            switch (direction)
            {
                case Direction.Up: nx = x - 1; ny = y; break;
                case Direction.Down: nx = x + 1; ny = y; break;
                case Direction.Left: nx = x; ny = y - 1; break;
                case Direction.Right: nx = x; ny = y + 1; break;
            }
            char temp = flag[x, y];
            flag[x, y] = flag[nx, ny];
            flag[nx, ny] = temp;

            if (IsState)
                return true;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.flag[i, j] = clone.flag[i, j];
                }
            }

            return false;
        }

        public bool IsOperator(int x, int y, Direction direction)
        {
            if (flag[x, y] != 'G' && flag[x, y] != 'R')
                return false;
            char neighbour = '\0';
            switch (direction)
            {
                case Direction.Up:
                    if (x - 1 < 0) return false;
                    neighbour = flag[x - 1, y]; break;
                case Direction.Down:
                    if (x + 1 > 2) return false;
                    neighbour = flag[x + 1, y]; break;
                case Direction.Left:
                    if (y - 1 < 0) return false;
                    neighbour = flag[x, y - 1]; break;
                case Direction.Right:
                    if (y + 1 > 4) return false;
                    neighbour = flag[x, y + 1]; break;
            }
            return neighbour == 'W';
        }
    }
}
