namespace DoublyLinkedList;

public class DNode(int data, DNode? next = null, DNode? prev=null)
{
    public int Data { get; set; } = data;
    public DNode? Next { get; set; } = next;
    public DNode? Prev { get; set; } = prev;
}