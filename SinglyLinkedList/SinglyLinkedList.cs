using System;
using System.Collections;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedListNode<T> Head;
        public int Count = 0;

        public SinglyLinkedList()
        {

        }

        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                AddLast(item);
        }

        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);

            if (Head == null)
            {
                Head = newNode;
                Count++;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
                Count++;
            }
        }

        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            var temp = Head;

            if (Head == null)
            {
                Head = newNode;
                Count++;
            }
            else if(Head != null)
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                Count++;
            }
        }

        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            var temp = Head;

            if (node == null)
                throw new ArgumentNullException();

            if (Head == null)
            {
                AddFirst(value);
                return;
            }

            while (temp != null)
            {
                if (temp.Equals(node))
                {
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                    Count++;
                    return;
                }
                temp = temp.Next;
            }
            throw new ArgumentException();
        }

        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null || value == null)
                throw new ArgumentNullException();

            var newNode = new SinglyLinkedListNode<T>(value);
            var temp = Head;
            var prevNode = temp;

            if (prevNode == Head)
                AddFirst(value);

            while (temp != null)
            {
                if (temp.Equals(node))
                {
                    newNode.Next = prevNode.Next;
                    prevNode.Next = newNode;
                    Count++;
                    return;
                }
                prevNode = temp;
                temp = temp.Next;
            }
            throw new ArgumentException();
        }

        public void Show()
        {
            SinglyLinkedListNode<T> temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }

        public T RemoveFirst()
        {
            if (Head.Equals(null))
                throw new Exception();

            var firstValue = Head.Value;
            Head = Head.Next;
            Count--;
            return firstValue;
        }

        public T RemoveLast()
        {
            if (Head == null || Head.Next == null)
            {
                Head = null;
                Count = 0;
            }
            
            var current = Head;
            SinglyLinkedListNode<T> prev = null;

            while (current.Next != null)
            {
                prev = current;
                current = current.Next;
            }
            var lastValue = prev.Next.Value;
            prev.Next = null;
            Count--;
            return lastValue;
        }

        public void Remove(T value)
        {
            var current = Head;
            SinglyLinkedListNode<T> prev = null;

            if (Head.Equals(null))
                throw new Exception();
           
            if (value == null)
                throw new ArgumentNullException();

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    prev.Next = current.Next;
                    Count--;
                    return;
                }
                prev = current;
                current = current.Next;
            }
            throw new ArgumentException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
