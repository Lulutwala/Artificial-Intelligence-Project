using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class State : ICloneable
    {
        public abstract bool IsState{ get; }
        public abstract bool IsGoalState{ get; }

        public abstract object Clone();

        public override bool Equals(object? obj) { throw new NotImplementedException(); }
        public override int GetHashCode() { throw new NotImplementedException(); }
    }
}
