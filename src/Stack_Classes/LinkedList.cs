using System;
using System.Collections.Generic;

namespace Stack_Classes
{
    public class LinkedList<T>
    {
        //Helper class that creates the Nodes which make up the LinkedList
        private class Node
        {
            public Node Next;
            public T Data;

            //Creates a Node instance that contains the data in the parameter and which does not point to any Node instance
            public Node(T data)
            {
                this.Data = data;
                this.Next = null;
            }
        }

        private Node Head; //Node reference to the Head of the list

        //Class constructor creates an instance of a LinkedList with an empty Head reference 
        public LinkedList()
        {
            this.Head = null;
        }

        //Adds an item to the end of the list. Returns true once the item has been added
        public bool Add(T data)
        {
            if (IsEmpty())
            {
                this.Head = new Node(data);
            }
            else
            {
                Node current = this.Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(data);
            }
            return true;
        }

        //Removes the last object in the list and returns its data
        public T Remove()
        {
            T toReturn;
            if (Head.Next == null)
            {
                toReturn = Head.Data;
                Head = null;
            }
            else
            {
                Node current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                toReturn = current.Next.Data;
                current.Next = null;
            }
            return toReturn;
        }

        //Returns the data stored in the object at the top of the stack without removing it
        public T GetLast()
        {
            Node current = this.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current.Data;
        }

        //Iterates through the LinkedList and prints out all the objects (elements) in the LinkedList from start to finish
        public void PrintContents()
        {
            Node current = this.Head;
            Console.Write(current.Data);
            while (current.Next != null)
            {
                current = current.Next;
                Console.Write(", " + current.Data);
            }
            Console.WriteLine();
        }

        //Removes all objects from the list when called
        public void EmptyList()
        {
            this.Head = null;
        }

        //Helper method that checks to see if a list is empty (has no elements), returns true if it is
        public bool IsEmpty()
        {
            if (this.Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}