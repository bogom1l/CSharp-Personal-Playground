namespace TreesAndTreeTraversalAlgorithmsDemo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            Console.WriteLine("Inorder traversal of binary tree: ");
            tree.PrintInorder();
        }
    }
}