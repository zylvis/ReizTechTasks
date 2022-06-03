using System;
using System.Collections.Generic;
using System.Text;

namespace TreeStructure
{
    class Branch
    {      
        private readonly int value;
        private bool hasParent;
        private List<Branch> branches;
       
        public Branch(int value)
        {
            this.value = value;
            this.branches = new List<Branch>();
        }

        public int ChildrenCount
        {
            get
            {
                return this.branches.Count;
            }
        }
       
        public void AddChild(Branch branch)
        {
            if (branch == null)
            {
                throw new ArgumentNullException(
                "Cannot insert null value!");
            }
            if (branch.hasParent)
            {
                throw new ArgumentException(
                "The node already has a parent!");
            }
            branch.hasParent = true;
            this.branches.Add(branch);
        }
       
        public Branch GetChild(int index)
        {
            return this.branches[index];
        }
    }
}

