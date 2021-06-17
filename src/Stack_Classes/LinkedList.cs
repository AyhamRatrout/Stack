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
        private int Size;

        //Class constructor creates an instance of a LinkedList with an empty Head reference 
        public LinkedList()
        {
            this.Head = null;
            this.Size = 0;
        }

        //Adds an item (the passed in parameter) to the end of the list when invoked
        public void Add(T data)
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
            this.Size++;
        }

        //Removes the last object in the list and returns its data. Throws an InvalidOperationException if list is empty
        public T Remove()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Invalid operation! Cannot remove from an empty list...");
            }
            else
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
                this.Size--;
                return toReturn;
            }    
        }

        //Iterates through the LinkedList and prints out all the objects (elements) in the LinkedList from start to finish. If list is empty, displays an error message
        public void PrintContents()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Cannot print the contents of an empty list...");
            }
            else
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
        }
        
        //Returns the last element in the list if it exists. Throws an InvalidOperationException is the list is empty
        public T GetLast()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Invalid operation! Cannot retrieve the last item of empty list...");
            }
            else
            {
                Node current = this.Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                return current.Data;
            }
        }

        //Removes all objects from the list when called. If list is empty, displays an error message 
        public void EmptyList()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Operation failed! The list was already empty when the call was made...");
            }
            else
            {
                this.Size = 0;
                this.Head = null;
            }
        }

        //Helper method that checks to see if a list is empty (has no elements), returns true if it is
        private bool IsEmpty()
        {
            return this.Size == 0;
        }
    }
}