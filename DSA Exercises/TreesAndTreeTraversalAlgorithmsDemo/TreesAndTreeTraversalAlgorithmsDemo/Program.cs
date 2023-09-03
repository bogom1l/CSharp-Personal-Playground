namespace TreesAndTreeTraversalAlgorithmsDemo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(220);
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);
            tree.Insert(3);
            tree.Insert(8);
            tree.Insert(123);

            Console.WriteLine("Inorder traversal of binary tree: ");
            tree.PrintInorder();

            tree.PrintTree();

            Console.WriteLine("\n------------------------------------------------------------------------------");

            Console.WriteLine("Please enter a value (int) you would like to search in the Binary Search Tree: ");
            int valueToSearch = int.Parse(Console.ReadLine());

            Node result = tree.Search(valueToSearch);
            if (result != null)
            {
                Console.WriteLine("Found: " + result.Data);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}