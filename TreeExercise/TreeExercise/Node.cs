namespace TreeExercise
{
    public class Node<T>
    {
        public Node(T Value, params Node<T>[] children)
        {
            this.Value = Value;
            this.Children = children.ToList();
        }

        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}