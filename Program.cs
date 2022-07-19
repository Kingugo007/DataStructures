using DSA.LinkedList;
using DSA.Stack;
using DSA.Queue;


Console.WriteLine("Stack data structures");
DSA.Stack.Stack<int> stk = new DSA.Stack.Stack<int>();
stk.Push(1);
stk.Push(2);
stk.Push(3);
stk.Push(4);
Console.WriteLine("count " + stk.Size());
stk.Pop();
foreach (var item in stk)
{
    Console.WriteLine(item);
}
stk.Push(5);
Console.WriteLine("Peek " + stk.Peek());
Console.WriteLine("stack empty " + stk.IsEmpty());

Console.WriteLine();
Console.WriteLine("Queue Data structures");
DSA.Queue.Queue<int> uq = new DSA.Queue.Queue<int>();
uq.Enqueue(1);
uq.Enqueue(2);
uq.Enqueue(3);
uq.Enqueue(4);

Console.WriteLine("count : " + uq.Size());
Console.WriteLine("check if empty : " + uq.IsEmpty());

foreach (int i in uq)
{
    Console.WriteLine(i);
}



Console.WriteLine();
Console.WriteLine("Singly linkedlist data structures");

SinglyLinkedList<int> ll = new SinglyLinkedList<int>();

ll.Add(0);
ll.Add(1);
ll.Add(2);
ll.Add(3);

foreach(int i in ll)
{
    Console.WriteLine(i);
}

Console.WriteLine("Remove : " + ll.Remove(1));


foreach (int i in ll)
{
    Console.WriteLine(i);
}

Console.WriteLine("Remove : " + ll.Check(2));

Console.WriteLine("Remove : " + ll.Index(2));