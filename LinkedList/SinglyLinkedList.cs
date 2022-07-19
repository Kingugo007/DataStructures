using DSA.Utilities;
using System;
using System.Collections;

namespace DSA.LinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public Node<T>? First { get; set; }
        public Node<T>? Last { get; set; }
        public int Count { get; set; }


        // Adding new nodes to the linkedlist
        public int Add(T target)
        {
            Node<T> newNode = new Node<T>(target);
            if (First == null)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
            return Count++;
        }

        // Remove item from the linked list
        public bool Remove(T target)
        {
            Node<T>? temp = First;
            Node<T>? prev = null;
            if (temp != null && temp.Data.Equals(target))
            {
                First = temp.Next;
                return true;
            }
            while (temp != null && !temp.Data.Equals(target))
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp == null)
            {
                return false;
            }
            prev.Next = temp.Next;

            return true;
        }

        // check if an item exits in the list
        public bool Check(T target)
        {
            Node<T>? currentNode = First;
            int index = 0;
            if (currentNode != null && currentNode.Data.Equals(target))
            {
                return true;
            }
            for (currentNode = First; currentNode != null; currentNode = currentNode.Next, index++)
            {
                if (currentNode.Data.Equals(target))
                {
                    return true;
                }
            }
            return false;
        }

        // Returns the index of an item in the linklist
        public int Index(T target)
        {
            int index = 0;
            for (var currentNode = First; currentNode != null; currentNode = currentNode.Next, index++)
            {
                if (currentNode.Data.Equals(target))
                {
                    return index;
                }
            }
            return -1;

        }

        //Size(): returns the size of the linkedlist
        public int Size()
        {
            return Count;
        }

        // Using the Ienumerator so the stack cam be looped through
        public IEnumerator<T> GetEnumerator()
        {
            Node<T>? current = First;
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
