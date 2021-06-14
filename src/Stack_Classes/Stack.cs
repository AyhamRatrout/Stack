using System;
using System.Collections.Generic;

namespace Stack_Classes
{
    public class Stack<T>
    {
        private LinkedList<T> list;

        //Class constructor, creates an instance of LinkedList to implement the Stack structure
        public Stack()
        {
            this.list = new LinkedList<T>();
        }

        //Pushes an element (the passed in parameter) to the top of the stack when called and returns true to signal success
        public bool Push(T data)
        {
            Console.WriteLine($"{data} was added to the stack!");
            return list.Add(data);
        }

        //Removes the object at the top of the stack and returns its data. Throws an exception if the stack is already empty. 
        public T Pop()
        {
            if (list.IsEmpty())
            {
                throw new InvalidOperationException("Invalid operation! Cannot remove from an empty stack...");
            }
            else
            {
                Console.WriteLine($"The item on at the top of the stack was removed successfully! That item was: {list.GetLast()}");
                return list.Remove();
            }

        }

        //Prints out all stack objects from oldest to newest or prints an error message if the stack is empty
        public void Print()
        {
            if (list.IsEmpty())
            {
                Console.WriteLine("Cannot print the contents of an empty stack...");
            }
            else
            {
                list.PrintContents();
            }
        }

        //Prints the object on the top of the stack without removing it if it exists or prints an error message
        public bool Peak()
        {
            if (list.IsEmpty())
            {
                Console.WriteLine("Error performing this operation! Cannot get the top element of an empty stack...");
                return false;
            }
            else
            {
                Console.WriteLine($"The top element in the stack is: {list.GetLast()}");
                return true;
            }
        }

        //Removes all objects from the stack and returns true to signal success or false if the stack was already empty
        public bool Clear()
        {
            if (list.IsEmpty())
            {
                Console.WriteLine("Operation failed! The stack was already empty when the call was made...");
                return false;
            }
            else
            {
                Console.WriteLine("Stack was cleared successfully!");
                list.EmptyList();
                return true;
            }
        }
    }
}