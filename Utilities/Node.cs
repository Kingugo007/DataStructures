using System;

namespace DSA.Utilities
{
    public class Node<T>
    {
        // data
        public T? Data { get; set; }
        // link
        public Node<T>? Next { get; set; }
        // constructor
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
}


