using DSA.Utilities;
using System;
using System.Collections;

namespace DSA.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        public Node<T>? top;
        public int count = 0;

        // Adding items to the stack
        public void Push(T item)
        {
            Node<T> temp = new Node<T>(item);
            temp.Next = top;
            top = temp;
            count++;
        }

        //Pop(): Removes the last item
        public T Pop()
        {
            if (Size() == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }

        //Size(): Returns the size of the stack
        public int Size()
        {
            return count;
        }

        //Peek(): Returns the last item
        public T Peek()
        {
            if (Size() == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            return top.Data;

        }

        //IsEmpty() : checks if the stack is empty
        public bool IsEmpty()
        {
            if (Size() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Using the Ienumerator so the stack cam be looped through
        public IEnumerator<T> GetEnumerator()
        {
            Node<T>? current = top;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
