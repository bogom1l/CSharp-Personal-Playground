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

        public void PrintTree()
        {
            Console.WriteLine("\n");
            PrintTree(Root, "", true);
        }

        private void PrintTree(Node node, string prefix, bool isLeft)
        {
            if (node != null)
            {
                Console.Write(prefix);
                Console.Write(isLeft ? "├──" : "└──");
                Console.WriteLine(node.Data);

                string newPrefix = prefix + (isLeft ? "│   " : "    ");
                PrintTree(node.Left, newPrefix, true);
                PrintTree(node.Right, newPrefix, false);
            }
        }

        //---------
        public Node Search(int searchedValue)
        {
            return SearchRecursive(this.Root, searchedValue);
        }

        // Private recursive search method
        private Node SearchRecursive(Node root, int searchedValue)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Data == searchedValue)
            {
                return root;
            }
            else if (root.Data < searchedValue)
            {
                return SearchRecursive(root.Right, searchedValue);
            }
            else
            {
                return SearchRecursive(root.Left, searchedValue);
            }
        }
    }
}