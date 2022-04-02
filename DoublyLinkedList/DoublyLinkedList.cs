using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }
        public int Count { get; set; }

        public DoublyLinkedList()
        {

        }
        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                AddLast(item);
        }

        public void AddFirst(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);

            if (Head != null)
                Head.Prev = newNode;

            newNode.Next = Head;
            newNode.Prev = null;
            Head = newNode;
            Count++;

            if (Tail == null)
                Tail = Head;

            return;
        }

        public void AddLast(T value)
        {
            if (Tail == null)
            {
                AddFirst(value);
                return;
            }

            var newNode = new DoublyLinkedListNode<T>(value);
            Tail.Next = newNode;
            newNode.Next = null;
            newNode.Prev = Tail;
            Tail = newNode;
            Count++;
            return;
        }

        public void AddAfter(DoublyLinkedListNode<T> node, T value)
        {
            if (value == null || node.Equals(null))
                throw new ArgumentNullException();

            var newNode = new DoublyLinkedListNode<T>(value);

            if (node == Head && node == Tail)
            {
                node.Next = newNode;
                node.Prev = null;
                newNode.Prev = node;
                newNode.Next = null;

                Head = node;
                Tail = newNode;
                Count++;
                return;
            }

            if (node != Tail)
            {
                newNode.Prev = node;
                newNode.Next = node.Next;
                node.Next.Prev = newNode;
                node.Next = newNode;
                Count++;
                return;
            }
            else
            {
                newNode.Prev = node;
                newNode.Next = null;
                node.Next = newNode;
                Tail = newNode;
                Count++;
            }
        }

        public void AddBefore(DoublyLinkedListNode<T> node, T value)
        {
            if (value is null || node is null)
                throw new ArgumentNullException();

            var newNode = new DoublyLinkedListNode<T>(value);
            var temp = Head;

            if (node == Head || node == Tail)
            {
                node.Prev = newNode;
                newNode.Next = node;
                newNode.Prev = null;
                node.Next = null;

                Head = newNode;
                Tail = node;
                Count++;
                return;
            }

            while (temp != null)
            {
                if (temp.Value.Equals(node.Value))
                {
                    newNode.Next = temp;
                    newNode.Prev = temp.Prev;
                    temp.Prev.Next = newNode;
                    temp.Prev = newNode;
                    Count++;
                    return;
                }
                temp = temp.Next;
            }
        }

        public T RemoveFirst()
        {
            if (Head is null)
                throw new Exception();

            var temp = Head.Value;

            if (Head == Tail)
            {
                Head = null;
                Tail = null;
                Count--;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
                Count--;
            }
            return temp;
        }

        public T RemoveLast()
        {
            if (Tail is null)
                throw new Exception();

            var temp = Tail.Value;

            if (Tail == Head)
            {
                Head = null;
                Tail = null;
                Count--;
            }
            else
            {
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
                Count--;
            }
            return temp;
        }

        public void Remove(T value)
        {
            if (Head is null)
                throw new Exception("Empty list.");

            if (Head == Tail)
            {
                if (Head.Value.Equals(value))
                {
                    RemoveFirst();
                    Count--;
                }
                return;
            }

            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;
                    Count--;
                    return;
                }
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new DoublyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
