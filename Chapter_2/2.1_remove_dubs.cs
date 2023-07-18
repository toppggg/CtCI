namespace CtCI;
using System.Collections.Generic;
using System;

public static class Remove_dubs{
    public static LinkedList<int> Method1(LinkedList<int> lst) {
        HashSet<int> hash = new HashSet<int>();

        if (lst.Head != null) {
            LinkedListNode<int> node = lst.Head;
            // LinkedListNode<int> next = node.Next;
            while (node != null) {
                while ( node.Next != null && hash.Contains(node.Next.Data)) {
                    node.Next = node.Next.Next;
                    lst.Count --;
                }
                if (node.Next != null) hash.Add(node.Next.Data);
                node = node.Next;
                }
        }
        return lst;
    }

    public static void Test() {
        System.Console.WriteLine("2.1_remove dubs:");
        LinkedList<int> lst = new LinkedList<int>();
        Random rnd = new Random();
        lst.Head = new LinkedListNode<int> (5);
        for (int i = 0; i < 20; i++) {
            int node = rnd.Next(10);
            System.Console.Write(node);
            lst.AddToEnd(node);
        }
        System.Console.WriteLine("");
        LinkedList<int> result = Method1(lst);
        System.Console.WriteLine("count = {0}", result.Count);
    }
}