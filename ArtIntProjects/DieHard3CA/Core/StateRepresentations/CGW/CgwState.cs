using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class CgwState : State, IOperatorHandler<CarryAction>
    {
        public override bool IsState => throw new NotImplementedException();

        public override bool IsGoalState => throw new NotImplementedException();

        public bool ApplyOperator(CarryAction t1)
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public bool IsOperator(CarryAction t1)
        {
            throw new NotImplementedException();
        }
    }
}
