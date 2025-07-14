using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class DieHard3SolverBase
    {
        private DieHard3Node startNode;

        public DieHard3SolverBase()
        {
            this.startNode = new DieHard3Node();
        }

        public abstract DieHard3Node Search();

        public Stack<DieHard3Node> Solution(DieHard3Node terminalNode)
        {
            if (terminalNode == null)
                return null;

            Stack<DieHard3Node> solution = new Stack<DieHard3Node>();
            DieHard3Node node = terminalNode;
            while (node != null)
            {
                solution.Push(node);
                node = node.Parent;
            }
            return solution;
        }
    }
}
