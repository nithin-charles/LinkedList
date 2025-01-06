namespace SinglyLinkedList;

public class Node(int data)
{
    public int Data { get; set; } = data;
    public Node? Next { get; set; } = null;

    public void DisplayData()
    {
        Console.Write($"{Data} -> ");
    }
}