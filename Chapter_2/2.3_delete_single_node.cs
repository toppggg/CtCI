namespace CtCI;
using System;
public static class DeleteSingleLinkedNode{
    public static void Method(ref LinkedListNode<int> Node) {
        Node.Data = Node.Next.Data;
        Node.Next = Node.Next.Next;
    }


    public static void Test() {
        System.Console.WriteLine("2.3 Delete node:");
        LinkedList<int> lst = new LinkedList<int>();
        Random rnd = new Random();
        lst.Head = new LinkedListNode<int> (5);
        for (int i = 0; i < 20; i++) {
            int node = rnd.Next(10);
            lst.AddToEnd(node);
        };
        System.Console.Write("Initial list:"); lst.PrintList();

        LinkedListNode<int> input = lst.Head.Next;
        Method(ref input);
        System.Console.Write("Edited list :"); lst.PrintList();
    }
}