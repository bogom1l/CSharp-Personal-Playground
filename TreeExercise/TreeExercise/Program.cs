namespace TreeExercise
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Node<int> root = new Node<int>(7,
                new Node<int>(19,
                    new Node<int>(1),
                    new Node<int>(12),
                    new Node<int>(31)),
                new Node<int>(21),
                new Node<int>(14,
                    new Node<int>(23),
                    new Node<int>(6))
            );

            Tree<int> tree = new Tree<int>();
            tree.Root = root;

            //BFS (Breadth-First Search) (търсене първо в широчина)
            List<Node<int>> treeAsList = tree.BFS(root);
            Console.WriteLine(string.Join(", ", treeAsList));

            Console.WriteLine("---------");

            //DFS (Depth-First Search) (търсене първо в дължина)
            tree.DFS(root, 0);
        }
    }
}