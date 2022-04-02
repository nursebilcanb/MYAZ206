using DoublyLinkedList;
using System;

namespace LinkedListConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        private static void DoublyLinkedList_AddBefore()
        {
            var db_list = new DoublyLinkedList<int>();

            db_list.AddFirst(15);
            db_list.AddFirst(25);
            db_list.AddFirst(35);

            db_list.AddBefore(db_list.Tail.Prev, 5);
            
            foreach (var item in db_list)
            {
                Console.WriteLine(item);
            }
        }

        private static void SinglyLinkedListRemove()
        {
            var list = new SinglyLinkedList.SinglyLinkedList<int>(new int[] { 23, 44, 32, 55 });
            list.Remove(55);
            list.Remove(13);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void OperationsOfAddMethod()
        {
            var _linkedList = new SinglyLinkedList.SinglyLinkedList<int>();
            _linkedList.AddFirst(1);
            _linkedList.AddFirst(24);
            _linkedList.AddFirst(37);
            _linkedList.AddLast(8);
            _linkedList.AddLast(45);

            foreach (var item in _linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
