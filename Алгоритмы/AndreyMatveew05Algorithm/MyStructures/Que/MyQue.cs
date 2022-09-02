using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructures
{
    //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 05.
    //Реализовать очередь: 2. * С использованием односвязного списка
    class MyQue<T> : IEnumerable<T>
    {
        private MyNode<T> head;
        private MyNode<T> tail;
        private int count;
        public int Count { get => this.count; }
        public bool IsEmpty { get => count == 0; }
        public T FirstNode { get => IsEmpty ? throw new InvalidCastException("Очередь пуста") : head.Data; }
        public T LastNode { get => IsEmpty ? throw new InvalidCastException("Очередь пуста") : tail.Data; }
        public void Enqueue(T data)
        {
            MyNode<T> node = new MyNode<T>(data);
            MyNode<T> tempNode = tail;
            tail = node;

            if (count == 0) head = tail;
            else tempNode.NextNode = tail;

            count++;
        }
        public T Dequeue()
        {
            if (count == 0) throw new InvalidOperationException("Очередь пуста");

            T output = head.Data;
            head = head.NextNode;
            count--;
            return output;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public bool Contains(T data)
        {
            MyNode<T> currentNode = head;
            while(currentNode != null)
            {
                if (currentNode.Data.Equals(data)) return true;
                currentNode = currentNode.NextNode;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            MyNode<T> myNode = head;
            while(myNode != null)
            {
                yield return myNode.Data;
                myNode = myNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
