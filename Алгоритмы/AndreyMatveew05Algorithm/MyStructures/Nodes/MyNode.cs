namespace MyStructures
{
    class MyNode<T>
    {
        public T Data { get; set; }
        public MyNode<T> NextNode { get; set; }
        public MyNode(T data)
        {
            Data = data;
        }
    }
}
