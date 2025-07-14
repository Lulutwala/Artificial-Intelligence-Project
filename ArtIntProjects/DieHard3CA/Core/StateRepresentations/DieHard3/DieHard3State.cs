using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DieHard3State : State, IOperatorHandler<bool, DieHard3Action>
    {
        public DieHard3State()
        {
            this.can3 = 0;
            this.can5 = 0;
        }

        private int can3;
        private int can5;

        public override bool IsState
        {
            get
            {
                return 0 <= this.can3 && this.can3 <= 3 &&
                       0 <= this.can5 && this.can5 <= 5;
            }
        }

        public override bool IsGoalState
        {
            get { return this.can5 == 4; }
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool IsOperator(bool isCan3, DieHard3Action action)
        {
            if (isCan3)
            {
                switch (action)
                {
                    case DieHard3Action.Fill:
                        if (this.can3 == 3) return false;
                        return true;
                    case DieHard3Action.PourOut:
                        if (this.can3 == 0) return false;
                        return true;
                    case DieHard3Action.TransferFrom:
                        if (this.can3 == 0) return false;
                        if (this.can5 == 5) return false;
                        return true;
                    default: return false;
                }
            }
            else
            {
                switch (action)
                {
                    case DieHard3Action.Fill:
                        if (this.can5 == 5) return false;
                        return true;
                    case DieHard3Action.PourOut:
                        if (this.can5 == 0) return false;
                        return true;
                    case DieHard3Action.TransferFrom:
                        if (this.can5 == 0) return false;
                        if (this.can3 == 3) return false;
                        return true;
                    default: return false;
                }
            }
        }
        public bool ApplyOperator(bool isCan3, DieHard3Action action)
        {
            if (!IsOperator(isCan3, action))
                return false;

            DieHard3State clone = (DieHard3State)this.Clone();

            if (isCan3)
            {
                switch (action)
                {
                    case DieHard3Action.Fill: this.can3 = 3; break;
                    case DieHard3Action.PourOut: this.can3 = 0; break;
                    case DieHard3Action.TransferFrom:
                        int emptyPlaceInCan5 = 5 - this.can5;
                        int transferAmount = Math.Min(this.can3, emptyPlaceInCan5);
                        this.can3 -= transferAmount;
                        this.can5 += transferAmount;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (action)
                {
                    case DieHard3Action.Fill: this.can5 = 5; break;
                    case DieHard3Action.PourOut: this.can5 = 0; break;
                    case DieHard3Action.TransferFrom:
                        int emptyPlaceInCan3 = 3 - this.can3;
                        int transferAmount = Math.Min(this.can5, emptyPlaceInCan3);
                        this.can5 -= transferAmount;
                        this.can3 += transferAmount;
                        break;
                    default:
                        break;
                }
            }

            if (this.IsState)
                return true;

            this.can3 = clone.can3;
            this.can5 = clone.can5;

            return false;
        }

        public override int GetHashCode()
        {
            return this.can3.GetHashCode() + this.can5.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || this.GetHashCode() != obj.GetHashCode())
                return false;

            DieHard3State other = (DieHard3State)obj;

            return this.can3 == other.can3 && this.can5 == other.can5;
        }

        public override string ToString()
        {
            return $"{can3} - {can5}";
        }
    }
}
