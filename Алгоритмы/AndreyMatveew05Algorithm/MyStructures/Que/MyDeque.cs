using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructures
{
    //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 05.
    //***Реализовать двустороннюю очередь.
    class MyDeque<T> : IEnumerable<T>
    {
        MyDoubleNode<T> head;
        MyDoubleNode<T> tail;
        int count;
        public int Count { get => this.count; }
        public bool IsEmpty { get => count == 0; }
        public T FirstNode { get => IsEmpty ? throw new InvalidCastException("Дек пуст") : head.Data; }
        public T LastNode { get => IsEmpty ? throw new InvalidCastException("Дек пуст") : tail.Data; }
        public void AddLast(T data)
        {
            MyDoubleNode<T> node = new(data);

            if (head == null) head = node;
            else
            {
                tail.NextNode = node;
                node.PreviousNode = tail;
            }

            tail = node;
            count++;
        }
        public void AddFirst(T data)
        {
            MyDoubleNode<T> node = new(data);
            MyDoubleNode<T> temp = head;
            node.NextNode = temp;
            head = node;

            if (count == 0) tail = head;
            else temp.PreviousNode = node;

            count++;
        }
        public T RemoveFirst()
        {
            if (count == 0) throw new InvalidCastException("Дек пуст");
            T output = head.Data;

            if (count == 1) head = tail = null;
            else
            {
                head = head.NextNode;
                head.PreviousNode = null;
            }
            count--;
            return output;
        }
        public T RemoveLast()
        {
            if (count == 0) throw new InvalidCastException("Дек пуст");
            T output = tail.Data;

            if (count == 1) head = tail = null;
            else
            {
                tail = tail.PreviousNode;
                tail.NextNode = null;
            }
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
            MyDoubleNode<T> current = head;
            while(current != null)
            {
                if (current.Data.Equals(data)) return true;
                current = current.NextNode;
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            MyDoubleNode<T> current = head;
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
