using System.Collections.Generic;

namespace DFS
{
    internal class Node
    {
        public int index;
        public List<Node> children;
        public List<Node> visitedChildren; // Use this to remember which children you already explored
        public Node parent;

        public Node(int index, Node parent)
        {
            this.index = index;
            children = new List<Node>();
            visitedChildren = new List<Node>();
            this.parent = parent;
        }
        public void add_child(Node child)
        {
            children.Add(child);
        }
        public void add_parent(Node parent)
        {
            this.parent = parent;
        }
    }
}
