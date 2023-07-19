namespace CtCI;
using System;

public static class SumLists{
    #nullable enable
    public static LinkedList<int> MethodReverseOrder(LinkedList<int> lst1, LinkedList<int> lst2) {
        if (lst1 == null || lst1.Head == null || lst2 == null || lst2.Head == null) 
            throw new InvalidOperationException(); // assuming the list should contain 0 if representing 0, not null.
        int intval = 0;
        int multiplyer = 1;

        LinkedListNode<int> lst1node = lst1.Head;
        LinkedListNode<int> lst2node = lst2.Head;

        // Summation of lists
        while (lst1node != null || lst2node != null) {
            // System.Console.WriteLine(intval);
            if (lst1node != null) {
                // System.Console.WriteLine("added {0} to {1}", lst1node.Data * multiplyer, intval);
                intval += (lst1node.Data * multiplyer);
                lst1node = lst1node.Next;
            }
            if (lst2node != null) {
                // System.Console.WriteLine("added {0} to {1}", lst2node.Data * multiplyer, intval);
                intval += (lst2node.Data * multiplyer);
                lst2node = lst2node.Next;
            }
            multiplyer *=10;
        }

        //Create list from val

        LinkedList<int> result = new LinkedList<int>();
        if (intval == 0) result.Head = new LinkedListNode<int>(0); // If the sum resulted in 0, return 0
        else {
            result.Head = new LinkedListNode<int>(intval % 10);
            intval /= 10;
            LinkedListNode<int> tail = result.Head;
            while (intval != 0) {
                LinkedListNode<int> tmp = new LinkedListNode<int>(intval % 10);
                intval /= 10;
                tail.Next = tmp;
                tail = tmp; 
            }
        }    
        return result;
    }

    public static void Test() {
        System.Console.WriteLine("2.5 Sum lists:");
        LinkedList<int> lst1 = new LinkedList<int>();
        LinkedList<int> lst2 = new LinkedList<int>();
        Random rnd = new Random();
        lst1.Head = new LinkedListNode<int> (rnd.Next(10));
        lst2.Head = new LinkedListNode<int> (rnd.Next(10));
        for (int i = 0; i < 3; i++) {
            int node = rnd.Next(10);
            lst1.AddToEnd(node);
            int node2 = rnd.Next(10);
            lst2.AddToEnd(node2);
        }
        System.Console.WriteLine("numbers printed lowest to highest digits");
        lst1.PrintList();
        lst2.PrintList();
        // int partition = 2;
        LinkedList<int> result = MethodReverseOrder(lst1,lst2);
        result.PrintList();
    }
}