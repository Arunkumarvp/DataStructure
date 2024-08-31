using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class CircularLinkedList
    {
        private Node Head;
        public CircularLinkedList()
        {
            Head = null;
        }


        /// <summary>
        /// Inserts a new node with the given data into the circular linked list.
        /// </summary>
        /// <param name="Data">The data to be stored in the new node.</param>
        public void Insert(int Data)
        {
            Node newNode = new Node(Data);

            if (Head == null)
            {
                Head = newNode;
                Head.Next = Head; // pointing to itself
            }
            else
            {
                Node Temp = Head;

                while (Temp.Next != Head)
                {
                    Temp = Temp.Next;
                }

                Temp.Next = newNode;
                newNode.Next = Head;
            }
        }


        /// <summary>
        /// Displays the data of each node in the circular linked list.
        /// </summary>
        /// <param name="Data">This parameter is not used in this method. It is included for consistency with other methods in the class.</param>
        /// <remarks>
        /// If the circular linked list is empty, it prints "List is empty".
        /// Otherwise, it iterates through the list starting from the head node and prints each node's data.
        /// </remarks>
        public void Display(int Data)
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty");
            }
            Node temp = Head;
            do
            {
                Console.WriteLine(temp.Data + " ");
                temp = temp.Next;
            } while (temp != Head);
        }

        /// <summary>
        /// Deletes a node with the specified key from the circular linked list.
        /// </summary>
        /// <param name="key">The data value of the node to be deleted.</param>
        /// <remarks>
        /// If the list is empty, the function returns without any action.
        /// If the head node contains the key, the head node is updated accordingly.
        /// If the key is found in the list, the node is removed and the function returns.
        /// If the key is not found in the list, a message is printed to the console.
        /// </remarks>
        public void Delete(int key)
        {
            if (Head == null) return;

            Node temp = Head;
            Node prev = null;

            // If the head node itself holds the key
            if (temp != null && temp.Data == key)
            {
                if (temp.Next == Head)
                {
                    Head = null; // Only one node was present
                    return;
                }

                while (temp.Next != Head)
                {
                    temp = temp.Next;
                }

                temp.Next = Head.Next;
                Head = Head.Next;
                return;
            }

            // Search for the key to be deleted
            do
            {
                prev = temp;
                temp = temp.Next;
            } while (temp != Head && temp.Data != key);

            if (temp == Head)
            {
                Console.WriteLine("Node with data " + key + " not found.");
                return;
            }

            prev.Next = temp.Next;
        }
    }
}
