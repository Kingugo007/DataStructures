using DSA.Utilities;
using System;
using System.Collections;

namespace DSA.Queue
{
    public class Queue<T> : IEnumerable<T>
    {
        public Node<T>? Head;
        public Node<T>? Tail;
        public int count = 0;

        // check if queue is empty
        public bool IsEmpty()
        {
            return count == 0;
        }

        //Enqueue(): Adding new node of queue
        public void Enqueue(T value)
        {
            Node<T>? Item = new Node<T>(value);
            if (Head == null)
            {
                Head = Item;
            }
            else
            {
                Tail.Next = Item;
            }
            count++;
            Tail = Item;
        }

        //Dequeue(): Deleting a node for the tail

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The queue is empty.");

            }
            Node<T>? temp = Head;
            Head = Head.Next;
            count--;
            if (Head == null)
            {
                Tail = null;
            }
            return temp.Data;
        }

        //Size(): returns the size of the queue
        public int Size()
        {
            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T>? current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        // Using the Ienumerator so the Queue cam be looped through
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
