using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SinglyLinkedList
    {
        private Node head;
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
        /// Add the data in the last node
        /// </summary>
        /// <param name="data"></param>
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
        /// Print the all nodes in the list
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
        ///  Find a node with a specific value

        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node Find(int data)
        {
            Node current = head;

            while (current != null)
            {
                if (current.Data == data)
                {
                    return current;
                }
            }
            return null;
        }

        /// <summary>
        /// Delete a node with a specific value
        /// </summary>
        /// <param name="data"></param>
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
