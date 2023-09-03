namespace TreesAndTreeTraversalAlgorithmsDemo
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            this.Root = null;
        }

        public void Insert(int data)
        {
            this.Root = InsertRecursive(this.Root, data);
        }

        private Node InsertRecursive(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            if (data < root.Data)
            {
                root.Left = InsertRecursive(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = InsertRecursive(root.Right, data);
            }

            return root;
        }

        // Printing the nodes in ascending order
        public void PrintInorder()
        {
            InorderRecursive(this.Root);
        }

        private void InorderRecursive(Node root)
        {
            if (root != null)
            {
                InorderRecursive(root.Left);
                Console.Write(root.Data + " ");
                InorderRecursive(root.Right);
            }
        }
    }
}