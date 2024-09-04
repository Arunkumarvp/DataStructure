using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// Represents a singly linked list data structure.
    /// </summary>
    public class SinglyLinkedList
    {
        private Node head;

        /// <summary>
        /// Initializes a new instance of the SinglyLinkedList class.
        /// </summary>
        public SinglyLinkedList()
        {
            this.head = null;
        }

        /// <summary>
        /// Adds a new node with the specified data at the beginning of the linked list.
        /// </summary>
        /// <param name="data">The data to be stored in the new node.</param>
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        /// <summary>
        /// Adds a new node with the specified data at the end of the linked list.
        /// </summary>
        /// <param name="data">The data to be stored in the new node.</param>
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        /// <summary>
        /// Reverses the order of the nodes in the linked list.
        /// </summary>
        /// <returns>The data stored in the new head node after the reversal.</returns>
        public int ReverseList()
        {
            if (head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            Node curr = head;
            Node? prev = null;
            Node? next = null;
            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
            return head.Data;
        }

        /// <summary>
        /// Prints all the nodes in the linked list.
        /// </summary>
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.ToString() + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Finds the first node with the specified data in the linked list.
        /// </summary>
        /// <param name="data">The data to search for.</param>
        /// <returns>The first node with the specified data, or null if not found.</returns>
        public Node Find(int data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        /// <summary>
        /// Deletes the first node with the specified data from the linked list.
        /// </summary>
        /// <param name="data">The data to delete.</param>
        public void Delete(int data)
        {
            if (head == null)
            {
                return;
            }
            if (head.Data.Equals(data))
            {
                head = head.Next;
            }
            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                }
                current = current.Next;
            }
        }
    }
}
