namespace Practice2_Basics
{
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T val)
        {
            Value = val;
            Next = null;
        }
        public Node(T val, Node<T> next)
        {
            Value = val;
            Next = next;
        }
    }
}
