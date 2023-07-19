namespace CtCI;
using System;

public static class ListIntersection{
    public static bool Method(LinkedList<int> lst1, LinkedList<int> lst2) {
        if (lst1 == null || lst1.Head == null || lst2 == null || lst2.Head == null) return false;
        LinkedListNode<int> lastelm1 = lst1.Head;

        while (lastelm1.Next != null) {
            lastelm1 = lastelm1.Next;
        }

        LinkedListNode<int> lastelm2 = lst2.Head;
        while (lastelm2.Next != null) {
            lastelm2 = lastelm2.Next;
        }         
        if (object.ReferenceEquals(lastelm1, lastelm2)) return true;
        else return false;
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
        System.Console.WriteLine("2 different lists return: {0}",Method(lst1,lst2));
        System.Console.WriteLine("Same list return: {0}",Method(lst1,lst1));
        LinkedList<int> lst3 = new LinkedList<int>();
        lst3.Head = lst1.Head.Next;
        
        System.Console.WriteLine("lst1 and lst1.tail check returns: {0}",Method(lst1,lst3));
    }
}