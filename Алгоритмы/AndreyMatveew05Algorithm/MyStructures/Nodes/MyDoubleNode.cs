using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructures
{
    class MyDoubleNode<T>
    {
        public T Data { get; set; }
        public MyDoubleNode<T> NextNode { get; set; }
        public MyDoubleNode<T> PreviousNode { get; set; }
        public MyDoubleNode(T data)
        {
            Data = data;
        }
    }
}
