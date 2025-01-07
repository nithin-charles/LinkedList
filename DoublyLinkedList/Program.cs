namespace DoublyLinkedList;

class Program
{
    static void Main(string[] args)
    {
    #region Node creation
    
        var node1 = new DNode(1);
        var node2 = new DNode(2);
        var node3 = new DNode(3);
        var node4 = new DNode(4);
        
        node1.Next = node2;
        node2.Next = node3;
        node3.Next = node4;
        node1.Prev = null;
        
    #endregion

        var doublyLinkedList = new DoublyLinkedList(new DNode(1));
        doublyLinkedList.InsertAtFirst(new DNode(0));
        doublyLinkedList.InsertAtEnd(new DNode(2));
        doublyLinkedList.InsertAtEnd(new DNode(3));
        
        doublyLinkedList.DeleteAtBegining();
        doublyLinkedList.DeleteAtEnd();
        doublyLinkedList.InsertAtEnd(new DNode(3));
        doublyLinkedList.InsertAtEnd(new DNode(4));
        doublyLinkedList.InsertAtEnd(new DNode(5));
        
        doublyLinkedList.Reverse();
        


        doublyLinkedList.Display();
        Console.WriteLine($"Head => {doublyLinkedList.Head.Data}");
        Console.WriteLine($"Tail => {doublyLinkedList.Tail.Data}");

    }
}