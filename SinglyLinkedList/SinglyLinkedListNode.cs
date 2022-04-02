using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class SinglyLinkedListNode<T>
    {
        public T Value;
        public SinglyLinkedListNode<T> Next;

        public SinglyLinkedListNode(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
