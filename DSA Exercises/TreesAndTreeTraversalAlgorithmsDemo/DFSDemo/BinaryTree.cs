namespace DFSDemo
{
    public class BinaryTree
    {
        // Constructor to initialize a binary tree with a single root node
        public BinaryTree(int rootValue)
        {
            Root = new TreeNode(rootValue);
        }

        // Root of the binary tree
        public TreeNode Root { get; private set; }

        //// Depth-First Search (DFS) algorithm using recursion (Preorder Traversal)
        //public void DFS(TreeNode node)
        //{
        //    if (node == null)
        //        return;

        //    Console.Write(node.Val + " ");

        //    DFS(node.Left);
        //    DFS(node.Right);
        //}
        //

        public void DFS(TreeNode rootNode)
        {
            if (rootNode == null)
                return;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(rootNode);

            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                Console.Write(node.Val + " ");

                // Push the right child onto the stack first (since it needs to be processed later)
                if (node.Right != null)
                    stack.Push(node.Right);

                // Push the left child onto the stack (will be processed next)
                if (node.Left != null)
                    stack.Push(node.Left);
            }
        }
    }
}