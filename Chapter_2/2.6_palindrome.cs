namespace CtCI;

public static class ListPalindrome{
    public static bool Method(LinkedList<char> lst) {
        if (lst == null || lst.Head == null) return false;
        //Build comparison list
        LinkedList<char> verifyList = new LinkedList<char>();
        verifyList.Head = new LinkedListNode<char> (lst.Head.Data);
        LinkedListNode<char> node = lst.Head;
        while (node.Next != null) {
            LinkedListNode<char> tmp = new LinkedListNode<char>(node.Next.Data);
            tmp.Next = verifyList.Head;
            verifyList.Head = tmp;
            node = node.Next;
        }

        //Check if lists are identical
        LinkedListNode<char> node1 = lst.Head;
        LinkedListNode<char> node2 = verifyList.Head;
        while (node1 != null) {
            if (node1.Data != node2.Data) return false;
            else {
                node1 = node1.Next;
                node2 = node2.Next;
            }
        } 
        return true;
    }

    public static void Test() {
        System.Console.WriteLine("2.6 Palindrome list");
        LinkedList<char> lst = new LinkedList<char>();
        // LinkedListNode<char>  node1 = new LinkedListNode<char>('a');
        lst.AddToFront('a');
        lst.AddToEnd('a');
        lst.AddToFront('b');
        lst.AddToEnd('b');
        lst.AddToFront('c');
        lst.AddToEnd('c');
        lst.AddToFront('a');
        lst.AddToEnd('a');
        lst.PrintList();
        
        System.Console.WriteLine(Method(lst));
        
    }
}