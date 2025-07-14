using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DieHard3Node
    {
        private DieHard3Node parent;
        private int depth;
        private DieHard3State state;

        public DieHard3Node()
        {
            this.state = new DieHard3State();
            this.depth = 0;
            this.parent = null;
        }
        public DieHard3Node(DieHard3Node parent)
        {
            this.parent =parent;
            this.state = (DieHard3State)parent.state.Clone();
            this.depth = parent.depth + 1;
        }

        public DieHard3Node Parent { get { return this.parent; } }
        public int Depth { get { return this.depth; } }
        public DieHard3State State { get { return this.state; } }
        public bool IsTerminalNode { get { return this.state.IsGoalState; } }

        public override bool Equals(object? obj)
        {
            if (this == obj) return true;
            if (obj == null) return false;

            DieHard3State other = ((DieHard3Node)obj).state;
            return this.state.Equals(other);
        }

        public List<DieHard3Node> GetAllChildren()
        {
            List<DieHard3Node> children = new List<DieHard3Node>();
            foreach (bool isCan3 in new bool[] { true, false})
            {
                foreach (DieHard3Action action in Enum.GetValues(typeof(DieHard3Action)))
                {
                    DieHard3Node newNode = new DieHard3Node(this);
                    if (newNode.state.ApplyOperator(isCan3, action))
                        children.Add(newNode);
                }
            }
            return children;
        }
    }
}
