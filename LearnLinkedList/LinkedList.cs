using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLinkedList
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void INsertFirst(int data)
        {
            //Create the node 
            Node newNode = new Node();
            //Put the data in the node 
            newNode.Data = data;
            //Put the old date in the next
            newNode.Next = First;
            //Make the first the new node
            First = newNode;
        }
        public Node DeleteFirst()
        {
            //Assign The Temprory Variable
            Node temp = First;
            //Assign the next head
            First = First.Next;
            return temp;
        }
        public void DisplayList()
        {
            Console.WriteLine("Iterating thrw list...");
            Node current = First;
            while (current != null)
            {
                current.DesplayData();
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode; 

        }
    }
}
