namespace CtCI;
using System;

public static class Partition{

    public static LinkedList<int> Method(LinkedList<int> lst, int partitionElm) {
        if (lst == null) return null;
        if (lst.Head == null) return lst;
        
        //Create first node for the result list
        LinkedListNode<int> node = new LinkedListNode<int> (lst.Head.Data);
        node.Next = lst.Head.Next;
        LinkedListNode<int> tail = node;
        //Create the new list
        LinkedList<int> result = new LinkedList<int>();
        result.Head = node;
        //Iterate list, adding next element first or last.
        while (node.Next != null){
            node = node.Next;
            if (node.Data < partitionElm) {
            //     //Add to head
                LinkedListNode<int> nextElm = new LinkedListNode<int>(node.Data);
                nextElm.Next = result.Head;
                result.Head = nextElm;
            } else {
            //     //Add to tail
                LinkedListNode<int> nextElm = new LinkedListNode<int>(node.Data);
                tail.Next = nextElm;  
                tail = nextElm;
            }
        }
        return result;
    }

    public static void Test() {
        System.Console.WriteLine("2.4 Partition:");
        LinkedList<int> lst = new LinkedList<int>();
        Random rnd = new Random();
        lst.Head = new LinkedListNode<int> (5);
        for (int i = 0; i < 20; i++) {
            int node = rnd.Next(10);
            // System.Console.Write(node);
            lst.AddToEnd(node);
        }
        // System.Console.WriteLine("");
        lst.PrintList();
        int partition = 2;
        LinkedList<int> result = Method(lst,partition);
        result.PrintList();
    }
}