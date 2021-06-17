using System;
using System.Collections.Generic;

namespace Stack_Classes
{
    public class Stack<T>
    {
        private LinkedList<T> list;

        public int Size{get; private set;}

        //Class constructor, creates an instance of LinkedList to implement the Stack structure and initializes its size to zero
        public Stack()
        {
            this.list = new LinkedList<T>();
            this.Size = 0;
        }

        //Pushes an element (the passed in parameter) to the top of the stack when called and displays a message to the user to signal success
        public void Push(T data)
        {
            list.Add(data);
            this.Size++;
            Console.WriteLine($"{data} was added to the stack!");
        }

        //Removes the object at the top of the stack and returns its data. Throws an InvalidOperationException if the stack is empty. 
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Invalid operation! Cannot remove from an empty stack...");
            }
            else
            {
                Console.WriteLine($"The item on at the top of the stack was removed successfully! That item was: {list.GetLast()}");
                this.Size--;
                return list.Remove();
            }
        }

        //Prints out all stack objects from oldest to newest or prints an error message if the stack is empty
        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Cannot print the contents of an empty stack...");
            }
            else
            {
                list.PrintContents();
            }
        }

        //Prints the element on the top of the stack without removing it if it exists. Throws an InvalidOperationException if the stack is empty
        public T Peak()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Invalid operation! Cannot retrieve the top item of empty stack...");                
            }
            else
            {
                Console.WriteLine($"The top element in the stack is: {list.GetLast()}");
                return list.GetLast();
            }
        }

        //Removes all objects from the stack if not empty. If stack is empty, displays an error message
        public void Clear()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Operation failed! The stack was already empty when the call was made...");
            }
            else
            {
                this.Size = 0;
                list.EmptyList();
                Console.WriteLine("Stack was cleared successfully!");
            }
        }

        //helper method that checks if the stack is empty. If it is, returns true otherwise returns false
        private bool IsEmpty(){
            return this.Size == 0;
        }
    }
}