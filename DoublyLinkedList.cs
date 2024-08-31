using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> Head;

        private DoublyLinkedListNode<T> Tail;

        public DoublyLinkedList()
        {
            this.Head = null;
            this.Tail = null;
        }
        /// <summary>
        /// Adds a new node with the specified data to the beginning of the doubly linked list.
        /// </summary>
        /// <param name="data">The data to be stored in the new node.</param>
        /// <remarks>
        /// If the list is empty, the new node becomes both the head and tail of the list.
        /// Otherwise, the new node is inserted at the beginning of the list, and its 'Next' pointer is set to the current head of the list.
        /// The 'Previous' pointer of the new node is set to null.
        /// The head of the list is updated to the new node.
        /// If the list was not empty, the 'Previous' pointer of the current head of the list is set to the new node.
        /// </remarks>
        public void AddFirst(T data)
        {
            var newNode = new DoublyLinkedListNode<T>(data);

            if (this.Head == null)
            {
                this.Head = newNode;
                this.Tail = newNode;
            }
            else
            {
                newNode.Next = this.Head;
                this.Head.Previous = newNode;
                this.Head = newNode;
            }
        }

        /// <summary>
        /// Adds a new node with the specified data to the end of the doubly linked list.
        /// </summary>
        /// <param name="data">The data to be stored in the new node.</param>
        /// <remarks>
        /// If the list is empty, the new node becomes both the head and tail of the list.
        /// Otherwise, the new node is appended to the end of the list, and its 'Next' pointer is set to null.
        /// The 'Previous' pointer of the new node is set to the current tail of the list.
        /// The tail of the list is updated to the new node.
        /// </remarks>
        public void AddLast(T data)
        {
            var newNode = new DoublyLinkedListNode<T>(data);

            if (this.Head == null)
            {
                this.Head = newNode;
                this.Tail = newNode;
            }
            else
            {
                this.Tail.Next = newNode;
                newNode.Previous = this.Tail;
                this.Tail = newNode;
            }
        }


        /// <summary>
        /// Removes the first occurrence of the specified data from the doubly linked list.
        /// </summary>
        /// <param name="data">The data to be removed from the list.</param>
        /// <returns>
        /// <c>true</c> if the data was found and removed successfully; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method iterates through the list, comparing each node's data with the specified data.
        /// When a match is found, the node is removed from the list by updating the 'Next' and 'Previous' pointers of its neighboring nodes.
        /// If the removed node was the head or tail of the list, the 'Head' or 'Tail' reference is updated accordingly.
        /// If the specified data is not found in the list, the method returns <c>false</c>.
        /// </remarks>
        public bool Remove(T data)
        {
            var current = Head; // Fixed: changed 'head' to 'Head'

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        Head = current.Next; // Fixed: changed 'head' to 'Head'
                    }

                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        Tail = current.Previous; // Fixed: changed 'tail' to 'Tail'
                    }

                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Prints the elements of the doubly linked list to the console.
        /// </summary>
        /// <remarks>
        /// This method iterates through the list, starting from the head, and prints each node's data to the console.
        /// The elements are separated by a space, and a newline character is printed at the end.
        /// </remarks>
        public void PrintList()
        {
            var current = Head; // Fixed: changed 'head' to 'Head'

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }



    }
}
