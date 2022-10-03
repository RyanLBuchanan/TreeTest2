using BinaryTreeLibrary2;

namespace TreeTest2
{
    internal class TreeTest2
    {
        static void Main(string[] args)
        {
            int[] intArray = { 8, 2, 4, 3, 1, 7, 5, 6 };
            double[] doubleArray = { 8.8, 2.2, 4.4, 3.3, 1.1, 7.7, 5.5, 6.6 };
            string[] stringArray = { "eight", "two", "four", "three", "one", "seven", "five", "six" };

            // Create int Tree
            Tree intTree = new Tree();
            PopulateTree(intArray, intTree, nameof(intTree));
            TraverseTree(intTree, nameof(intTree));

            // Create double Tree
            Tree doubleTree = new Tree();
            PopulateTree(doubleArray, doubleTree, nameof(doubleTree));
            TraverseTree(doubleTree, nameof(doubleTree));

            // Create int Tree
            Tree stringTree = new Tree();
            PopulateTree(stringArray, stringTree, nameof(stringTree));
            TraverseTree(stringTree, nameof(stringTree));
        }

        // Populate Tree with array elements
        private static void PopulateTree(Array array, Tree tree, string name)
        {
            Console.WriteLine($"\n\nInserting into {name}:");

            foreach (IComparable data in array)
            {
                Console.Write($"{data} ");
                tree.InsertNode(data);
            }
        }

        // Perform traversals
        private static void TraverseTree(Tree tree, string treeType)
        {
            // Perform preorder traversal of tree
            Console.WriteLine($"\n\nPreorder traversal of {treeType}");
            tree.PreorderTraversal();

            // Perform inorder traversal of tree
            Console.WriteLine($"\n\nInorder traversal of {treeType}");
            tree.InorderTraversal();

            // Perform postorder traversal of tree
            Console.WriteLine($"\n\nPostorder traversal of {treeType}");
            tree.PostorderTraversal();
        }
    }
}