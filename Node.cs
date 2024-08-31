using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Node
    {
        public int Data {  get; set; }

        public Node Next { get; set; }


        public Node( int data)
        {
           this.Data = data;
           this.Next = null;
        }
    }


    public class DoublyLinkedListNode<T>
    {
        public T Data { get; set; }

        public DoublyLinkedListNode<T> Next { get; set; }

        public DoublyLinkedListNode<T> Previous {  get; set; }

        public DoublyLinkedListNode(T data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }

    }




}
