namespace TreeExercise
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Channels;

    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        //BFS (Breadth-First Search) (търсене първо в ширина)
        public List<Node<T>> BFS(Node<T> root)
        {
            List<Node<T>> list = new List<Node<T>>();

            Queue<Node<T>> queue = new Queue<Node<T>>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();
                list.Add(node);

                foreach (var child in node.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return list;
        }

        //DFS (Depth-First Search) (търсене първо в дължина)
        public void DFS(Node<T> node, int level) //using 'level' for more beautiful printing
        {
            Console.Write(new string(' ', level));
            Console.WriteLine(node);

            foreach (var child in node.Children)
            {
                DFS(child, level + 3);
            }
        }

    }
}
