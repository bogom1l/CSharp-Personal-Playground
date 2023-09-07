namespace DFSDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(1);

            // Add nodes to the binary tree
            tree.Root.Left = new TreeNode(2);
            tree.Root.Right = new TreeNode(5);

            tree.Root.Left.Left = new TreeNode(3);
            tree.Root.Left.Right = new TreeNode(4);

            tree.Root.Right.Left = new TreeNode(6);
            tree.Root.Right.Right = new TreeNode(7);

            // Perform DFS on the binary tree (Preorder Traversal)
            Console.WriteLine("DFS (Preorder Traversal):");
            tree.DFS(tree.Root);

            // Output: 1 2 4 5 3
        }
    }
}