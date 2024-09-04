using DataStructure;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        #region SingleLinkedList
        SinglyLinkedList list = new SinglyLinkedList();



        list.AddFirst(10);
        list.AddFirst(20);
        list.AddLast(30);
        list.ReverseList();
        list.PrintList(); // Output: 40 30 10 20
        list.PrintList(); // Output: 20 10 30


        Node foundNode = list.Find(10);
        if (foundNode != null)
        {
            Console.WriteLine("Node with data 10 found");
        }

        list.Delete(20);
        list.PrintList(); // Output: 10 30 
        #endregion

        #region DoubleLinkedList
        var doublyLinkedList = new DoublyLinkedList<int>();

        doublyLinkedList.AddLast(1);
        doublyLinkedList.AddLast(2);
        doublyLinkedList.AddLast(3);

        doublyLinkedList.AddFirst(0);

        doublyLinkedList.PrintList();  // Output: 0 1 2 3

        doublyLinkedList.Remove(2);

        doublyLinkedList.PrintList();  // Output: 0 1 3

        #endregion

        #region CircularLinkedList


        #endregion


    }


}
