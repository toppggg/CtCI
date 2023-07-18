namespace CtCI;
using System;

public static class KthedLast{

    public static LinkedListNode<int> MethodWithCount(LinkedList<int> lst, int k){
        if (lst == null || lst.Count == 0 || k < 0 || k >= lst.Count)
            throw new InvalidOperationException();
        LinkedListNode<int> result = lst.Head;
        int target = lst.Count - k;
        while (target >= 0){
            result = result.Next;
            target--;
        }
        return result;
    }

    public static LinkedListNode<int> MethodNoCount(LinkedList<int> lst, int k){
        if (lst == null || lst.Count == 0 || k < 0 )
            throw new InvalidOperationException();
        int count = 0;
        LinkedListNode<int> node = lst.Head;
        while (node.Next != null) { // Count number of nodes in the list
            node = node.Next;
            count++;
        }
        LinkedListNode<int> result = lst.Head;
        int target = count - k;
        while (target >= 0){
            result = result.Next;
            target--;
        }
        return result;
    }    

    public static void Test() {
        System.Console.WriteLine("2.2 K'th element:");
        LinkedList<int> lst = new LinkedList<int>();
        Random rnd = new Random();
        lst.Head = new LinkedListNode<int> (5);
        for (int i = 0; i < 20; i++) {
            int node = rnd.Next(10);
            System.Console.Write(node);
            lst.AddToEnd(node);
        }
        System.Console.WriteLine("");
        int k = 2;
        LinkedListNode<int> result1 = MethodWithCount(lst, k);
        System.Console.WriteLine("Key of {0}'th last element from Count is: {1}", k, result1.Data);
        LinkedListNode<int> result2 = MethodNoCount(lst, k);
        System.Console.WriteLine("Key of {0}'th last element from NoCount is: {1}", k, result2.Data);
    }
}