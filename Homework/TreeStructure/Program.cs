using System;
using System.Linq;

namespace TreeStructure
{
    class Program
    {
        static void Main()
        {
            Tree tree =
            new Tree(1,
                new Tree(2,
                    new Tree(4)),
                new Tree(3,
                    new Tree(5,
                        new Tree(1)),
                    new Tree(6,
                        new Tree(9,
                            new Tree(11)),
                        new Tree(10)),
                    new Tree(7))
            );

            tree.TraverseDepth();
            int depth = tree.Depths.Max();
            Console.WriteLine($"Structure depth is: {depth}");
        }
    }
}
