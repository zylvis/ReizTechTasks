using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeStructure
{
    public class Tree
    { 
        private readonly Branch root;
        private readonly int depth = 0;
        public List<int> Depths { get; set; } = new List<int>();

        public Tree(int value) 
        {
            root = new Branch(value);
        }
        public Tree(int value, params Tree[] children) : this(value)
        {
            foreach (Tree child in children)
            {
                root.AddChild(child.root);
            }
        } 
        private void CountDepth(Branch root, int depth)
        {
            if (this.root == null)
            {
                return;
            }

            depth++;
            Depths.Add(depth);

            for (int i = 0; i < root.ChildrenCount; i++)
            {           
                Branch child = root.GetChild(i);
                CountDepth(child, depth);
            }
        }
        public void TraverseDepth()
        {
            CountDepth(this.root, depth);
        }
    }
}
