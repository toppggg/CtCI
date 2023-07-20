namespace CtCI;
using System.Collections.Generic;
using System;

public static class LoopDetection{
    public static bool Method(LinkedList<int> lst) {
        if (lst == null || lst.Head == null) return false;

        HashSet<int> hashset = new HashSet<int>();
        LinkedListNode<int> node = lst.Head;

        while (node != null) {
            int hash = node.GetHashCode();
            if (hashset.Contains(hash)) return true;
            hashset.Add(hash);
            node = node.Next;
        }
        return false;
    }

    public static void Test() {
        System.Console.WriteLine("2.8_Loop detection:");
        LinkedList<int> lst = new LinkedList<int>();
        Random rnd = new Random();
        LinkedListNode<int> node1 = new LinkedListNode<int> (5);
        lst.Head = node1;
        for (int i = 0; i < 20; i++) {
            int node = rnd.Next(10);
            // System.Console.Write(node);
            lst.AddToEnd(node);
        }
        LinkedListNode<int> getLast = lst.Head;
        while (getLast.Next != null){
            getLast = getLast.Next;
        }
        getLast.Next = node1;
        bool result = Method(lst);
        System.Console.WriteLine("Loop in lst: {0}", result);
    }
}