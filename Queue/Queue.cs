﻿using System;

namespace Queue
{
    public class Queue<T>
    {
        private readonly IQueue<T> queue;
        public int Count => queue.Count;

        public Queue(QueueType queueType = QueueType.Array)
        {
            if (queueType == QueueType.Array)
                queue = new ArrayQueue<T>();
            else
                queue = new LinkedListQueue<T>();
        }

        public void EnQueue(T value)
        {
            queue.EnQueue(value);
        }

        public T DeQueue()
        {
            return queue.DeQueue();
        }

        public T Peek()
        {
            return queue.Peek();
        }
    }

    public interface IQueue<T>
    {
        int Count { get; }
        void EnQueue(T value);
        T DeQueue();
        T Peek();
    }

    public enum QueueType
    {
        Array = 0,            //List<T>
        LinkedList = 1        //DoublyLinkedList<T>
    }
}
