// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using SinglyLinkedList;

var nodeA = new Node(1);
var nodeB = new Node(2);
var nodeC = new Node(3);
var nodeD = new Node(4);

nodeA.Next = nodeB;
nodeB.Next = nodeC;
nodeC.Next = nodeD;

var linkedList = new SinglyLinkedList.SinglyLinkedList(nodeA);

// #region Insertion
// linkedList.InsertAtBegining(0);
// linkedList.InsertAtEnd(5);
// linkedList.DisplayLinkedList();
//
// linkedList.InsertAt(5, 700);
// linkedList.DisplayLinkedList();
// #endregion
// #region Delete
// linkedList.DeleteAtFirst();
// linkedList.DisplayLinkedList();
//
// linkedList.DeleteAtEnd();
// linkedList.DisplayLinkedList();
//
// linkedList.DeleteAt(4);
// linkedList.DisplayLinkedList();
// #endregion
// #region Search
// linkedList.Search(2);
// #endregion
// #region Length
// linkedList.Length();
// #endregion

linkedList.Reverse();
linkedList.DisplayLinkedList();
