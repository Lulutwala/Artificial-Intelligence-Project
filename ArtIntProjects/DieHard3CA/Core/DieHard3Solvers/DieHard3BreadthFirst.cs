using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DieHard3BreadthFirst : DieHard3SolverBase
    {
        bool checkCircle;
        Queue<DieHard3Node> openNodes;
        List<DieHard3Node> closedNodes;

        public DieHard3BreadthFirst(bool checkCircle = true)
        {
            this.checkCircle = checkCircle;
            openNodes = new Queue<DieHard3Node>();
            openNodes.Enqueue(new DieHard3Node());
            closedNodes = new List<DieHard3Node>();
        }

        public override DieHard3Node Search()
        {
            return checkCircle ?
                SearchWithCircleCheck() :
                SearchWithoutCircleCheck();
        }

        public DieHard3Node SearchWithoutCircleCheck()
        {
            while (openNodes.Count != 0)
            {
                List<DieHard3Node> childNodes = openNodes.Dequeue().GetAllChildren();
                foreach (DieHard3Node childNode in childNodes)
                {
                    if (childNode.IsTerminalNode)
                        return childNode;

                    openNodes.Enqueue(childNode);
                }
            }
            return null;
        }
        public DieHard3Node SearchWithCircleCheck()
        {
            while (openNodes.Count != 0)
            {
                DieHard3Node openNode = openNodes.Dequeue();
                List<DieHard3Node> childNodes = openNode.GetAllChildren();
                foreach (DieHard3Node node in childNodes)
                {
                    if (node.IsTerminalNode)
                        return node;

                    if (!closedNodes.Contains(node) && !openNodes.Contains(node))
                        openNodes.Enqueue(node);
                }
                closedNodes.Add(openNode);
            }
            return null;
        }
        public override DieHard3Node Search()
        {
            throw new NotImplementedException();
        }
    }
}
