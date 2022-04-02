using System.Collections;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private SinglyLinkedListNode<T> Head { get; set; }
        private SinglyLinkedListNode<T> _current { get; set; }


        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T> head)
        {
            Head = head;
            _current = null;
        }

        public T Current => _current.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = Head;
                return true;
            }
            else
            {
                if (_current.Next == null)
                {
                    return false;
                }
                else
                {
                    _current = _current.Next;
                    return true;
                }
            }
        }

        public void Reset()
        {
            _current = null;
        }
    }
}