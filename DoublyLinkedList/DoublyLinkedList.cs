namespace DoublyLinkedList;

public class DoublyLinkedList(DNode head)
{
    public DNode? Head { get; set; } = head;
    public DNode? Tail { get; set; } = head;

    public void InsertAtFirst(DNode node)
    {
        if (Head != null)
        {
            Head.Prev = node;
            node.Next = Head;
            Head = node;
        }
        else
        {
            Console.WriteLine("No Initial Node");
        }
    }

    public void InsertAtEnd(DNode node)
    {
        Tail.Next = node;
        node.Prev = Tail;
        Tail = node;
    }

    public void DeleteAtBegining()
    {
        // var current = Head;
        Head = Head.Next;
        Head.Prev = null;
    }

    public void DeleteAtEnd()
    {
        Tail = Tail.Prev;
        Tail.Next = null;
    }
    
    // Insertion and Delete at a given position is similar to singly Linked List;
    // Search and Length is also similar;
    
    /// <summary>
    /// Reverse the Doubly Linked List
    /// </summary>
    public void Reverse()
    {
        var current = Head;
        DNode? temp = null;
        while (current != null)
        {
            // Swap the next and prev pointers
            temp = current.Prev;
            current.Prev = current.Next;
            current.Next = temp;

            // Move to the next node (which is previous now)
            current = current.Prev;
        }

        // Reset the head to the last node
        if (temp != null)
        {
            Head = temp.Prev;
        }
    }

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Display the nodes...");
        Console.ResetColor();
        var current = Head;
        while (current != null)
        {
            Console.Write($"{current.Data} -> ");
            current = current.Next;
        }
        Console.WriteLine("\n");
    }

}