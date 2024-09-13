using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf
{
    internal class Node
    {
        public Node()
        {
        }

        public int index;
        public List<Node> children = new List<Node>();
        public Node parent = null;

        public void add_child (Node child)
        {
            children.Add(child);
        }
        public void add_parent (Node parent)
        {
            this.parent = parent;
        }
    }
}
