namespace CtCI;
public class LinkedListNode<T>
{
    public T Data { get; set; }
    public LinkedListNode<T> Next { get; set; }

    public LinkedListNode(T data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList<T>
{
    public LinkedListNode<T> Head { get; set; }
    public int Count { get; set; }

    public LinkedList()
    {
        Head = null;
        Count = 0;
    }

    public void AddToFront(T data)
    {
        LinkedListNode<T> newNode = new LinkedListNode<T>(data);
        newNode.Next = Head;
        Head = newNode;
        Count++;
    }

    public void AddToEnd(T data)
    {
        LinkedListNode<T> newNode = new LinkedListNode<T>(data);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            LinkedListNode<T> current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        Count++;
    }

    public bool Remove(LinkedListNode<T> node)
    {
        if (Head == null)
        {
            return false;
        }

        if (Head.Equals(node))
        {
            Head = Head.Next;
            Count--;
            return true;
        }

        LinkedListNode<T> current = Head;

        while (current.Next != null)
        {
            if (current.Next.Equals(node))
            {
                current.Next = current.Next.Next;
                Count--;
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    public bool Contains(T data)
    {
        LinkedListNode<T> current = Head;

        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    public void PrintList () {
        LinkedListNode<T> node = Head;
        while (node != null){
            System.Console.Write(node.Data);
            node = node.Next;
        }
        System.Console.WriteLine("");
    }
}
