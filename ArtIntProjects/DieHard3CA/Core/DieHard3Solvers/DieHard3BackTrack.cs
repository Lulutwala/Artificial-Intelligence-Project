using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DieHard3BackTrack : DieHard3SolverBase
    {
        private int limit; //0 means no limit
        private bool isMemorizable;

        public DieHard3BackTrack(int limit, bool isMemorizable)
        {
            this.limit = limit;
            this.isMemorizable = isMemorizable;
        }

        public override DieHard3Node Search()
        {
            return Search(new DieHard3Node());
        }

        public DieHard3Node Search(DieHard3Node actual)
        {
            //Depth limit
            int depth = actual.Depth;
            if (limit > 0 && depth >= limit)
                return null;

            //Memorizable
            DieHard3Node parent = null;
            if (isMemorizable)
            {
                parent = actual.Parent;
            }
            while(parent != null)
            {
                if (actual.Equals(parent))
                    return null;
                parent = parent.Parent;
            }

            //Check if we can stop
            if (actual.IsTerminalNode)
                return actual;

            //Algorithm
            foreach (bool isCan3 in new bool[] { false, true })
            {
                foreach (DieHard3Action action in Enum.GetValues(typeof(DieHard3Action)))
                {
                    DieHard3Node newNode = new DieHard3Node(actual);
                    if (newNode.State.ApplyOperator(isCan3, action))
                    {
                        DieHard3Node terminal = Search(newNode);
                        if (terminal != null)
                            return terminal;
                    }
                }
            }
            return null;
        }
    }
}
