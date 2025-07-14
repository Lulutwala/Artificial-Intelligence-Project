using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DieHard3DepthFirst : DieHard3SolverBase
    {
        bool checkCircle;
        Stack<DieHard3Node> openNodes;
        List<DieHard3Node> closedNodes;

        public DieHard3DepthFirst(bool checkCircle = true)
        {
            this.checkCircle = checkCircle;
            openNodes = new Stack<DieHard3Node>();
            openNodes.Push(new DieHard3Node());
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
                List<DieHard3Node> childNodes = openNodes.Pop().GetAllChildren();
                foreach (DieHard3Node childNode in childNodes)
                {
                    if (childNode.IsTerminalNode)
                        return childNode;

                    openNodes.Push(childNode);
                }
            }
            return null;
        }
        public DieHard3Node SearchWithCircleCheck()
        {            
            while (openNodes.Count != 0)
            {
                DieHard3Node openNode = openNodes.Pop();
                List<DieHard3Node> childNodes = openNode.GetAllChildren();
                foreach (DieHard3Node node in childNodes)
                {
                    if (node.IsTerminalNode)
                        return node;

                    if (!closedNodes.Contains(node) && !openNodes.Contains(node))
                        openNodes.Push(node);
                }
                closedNodes.Add(openNode);
            }
            return null;
        }
    }
}
