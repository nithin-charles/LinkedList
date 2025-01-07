namespace SinglyLinkedList;

public class SinglyLinkedList(Node head)
{
    /// <summary>
    /// To hold the head of the LinkedList's Node
    /// </summary>
    private Node? Head { get; set; } = head;

    public void InsertAtBegining(int value)
    {
        var node = new Node(value);
        node.Next = Head;
        Head = node;
    }

    public void InsertAt(int position, int value)
    {
        if (position < 0 || position > Length())
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if (position == 1)
        {
            InsertAtBegining(value);
        }

        var currentPosition = 1;
        var currentNode = Head;
        while (currentPosition < position-1 && currentNode != null)
        {
            currentNode = currentNode.Next;
            currentPosition++;
        }
        var temp = new Node(value);;
        temp.Next = currentNode.Next;

        currentNode.Next = temp;
    }

    public void InsertAtEnd(int value)
    {
        var node = new Node(value);
        var current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = node;
    }

    public void DisplayLinkedList()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Displaying LinkedList ...");
        Console.ResetColor();
        var current = Head;
        while (current != null)
        {
            current.DisplayData();
            current = current.Next;
        }

        Console.WriteLine("\n");
    }

    public void DeleteAtFirst()
    {
        var current = Head;
        if (current.Next != null)
        {
            Head = current.Next;
        }
    }

    public void DeleteAtEnd()
    {
        // if the linkedList is empty
        if (Head == null)
        {
            return;
        }
        
        // if the linkedList has only one node
        if (Head.Next == null)
        {
            Head = null;
        }
        var current = Head;
        while (current?.Next?.Next != null)
        {
            current = current.Next;
        }

        if (current != null) current.Next = null;
    }

    public void DeleteAt(int position)
    {
        if (position < 0 || position > Length())
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if (position == 1)
        {
            DeleteAtFirst();
            return;
        }
        var current = Head;
        var currentPosition = 1;
        while (currentPosition < position-1 && current != null)
        {
            current = current.Next;
            currentPosition++;
        }

        if (current != null) current.Next = current?.Next?.Next;
    }

    /// <summary>
    /// Search for the value
    /// </summary>
    /// <param name="value"></param>
    public void Search(int value)
    {
        var current = Head;
        while (current != null)
        {
            if(current.Data == value)
            {
                Console.WriteLine($"{value} is Found in LinkedList");
                return;
            }
            current = current.Next;
        }
    }

    /// <summary>
    /// Returns the Length of the LinkedList
    /// </summary>
    /// <returns></returns>
    public int Length()
    {
        var current = Head;
        var length = 0;
        while (current != null)
        {
            current = current.Next;
            length++;
        }

        Console.WriteLine($"Length of the Linked List: {length}");
        return length;
    }

    /// <summary>
    /// Reverses the Singly LinkedList
    /// Time Complexity = O(2N)
    /// Space complexity = O(1)
    /// </summary>
    public void Reverse()
    {
        var current = Head;
        var tail = Head;
        // Traversal to find the tail -> O(N)
        var length = 1;
        while (tail?.Next != null)
        {
            tail = tail.Next;
            length++;
        }
        // Traversal to move the nodes -> O(N)
        for (var i = 1; i < length; i++)
        {
            var nextHead = Head?.Next;
            Head.Next = null;
            var temp = tail.Next;
            tail.Next = Head;
            tail.Next.Next = temp;
            Head = nextHead;
        }
    }
}