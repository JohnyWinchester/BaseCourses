using System;
using System.Collections;
using System.Collections.Generic;

namespace MyStructures
{
    public class MyStack<T>: IEnumerable<T>
    {
        private MyNode<T> head;
        private int count;
        public int Count { get => this.count; }
        public bool IsEmpty { get => count == 0; }
        public void Push(T item)
        {
            MyNode<T> myNode= new(item);
            myNode.NextNode = head;
            head = myNode;
            count++;
        }
        public T Pop()
        {
            if (IsEmpty) throw new InvalidOperationException("Стек пуст");
            MyNode<T> temp = head;
            head = head.NextNode;
            count--;
            return temp.Data;
        }
        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Стек пуст");
            return head.Data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            MyNode<T> current = head;
            while(current != null)
            {
                yield return current.Data;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
