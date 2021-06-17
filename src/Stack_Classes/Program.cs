using System;

namespace Stack_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //test each one individually by commenting out the others as some throw exceptions
            TestStackPushMethod();
            Console.WriteLine("***********************************************************");
            TestStackPopMethod();
            Console.WriteLine("***********************************************************");
            TestStackPrintMethod();
            Console.WriteLine("***********************************************************");
            TestStackPeakMethod();
            Console.WriteLine("***********************************************************");
            TestStackClearMethod();

        }

        //Tests the Push method by instantiating an empty stack, pushing one item at a time, checking that the size of the stack gets incremented by one 
        //with each push using the stack's size property, and finally checking that the correct items are being pushed using the stack's Print() method
        private static void TestStackPushMethod()
        {
            var stack = new Stack<double>(); //creates a new empty stack
            Console.WriteLine($"The current size of the stack is: {stack.Size}"); //should display 0
            stack.Print(); //tests that an error message is displayed when trying to print the contents of an empty stack
            stack.Push(10.5); //adds first element
            stack.Print(); //to check that 10.5 has indeed been added
            Console.WriteLine($"The current size of the stack is: {stack.Size}"); //should display 1
            stack.Push(7.3); //adds second element
            stack.Print(); //to check that we now have 10.5 and 7.3 in that order
            Console.WriteLine($"The current size of the stack is: {stack.Size}"); //should display 2
            stack.Push(0.45); //adds third element
            stack.Print(); //to check that we now have 10.5, 7.3, and 0.45 in that order
            Console.WriteLine($"The current size of the stack is: {stack.Size}"); //should display 3
            stack.Push(22); //adds fourth element
            stack.Print(); //to check that we now have 10.5, 7.3, 0.45, and 22 in that order
            Console.WriteLine($"The current size of the stack is: {stack.Size}"); //should display 4
        }

        //Test the Pop method by instantiating an empty stack, adding 4 elements to the stack, then popping one element at a time to test that the correct (top) element
        //is being removed and that the size is decreasing by one with each pop. Also tests that stack throws an InvalidOperationException when attempting to pop from an 
        //empty stack
        private static void TestStackPopMethod()
        {
            var stack = new Stack<string>();
            Console.WriteLine($"The current size of the stack is: {stack.Size}"); //should display 0
            stack.Print(); //tests that an error message is displayed when trying to print the contents of an empty stack
            stack.Push("Foothill");
            stack.Push("Technology");
            stack.Push("Solutions");
            stack.Push("Company"); //add items to the stack to test the pop method
            Console.WriteLine($"The current size of the stack is: {stack.Size}"); //should display 4
            stack.Print(); //prints the stack after adding four items
            stack.Pop(); //removes Company from stack
            Console.WriteLine($"The current size of the stack is: {stack.Size}"); //should display 3
            stack.Print(); //prints the stack after the first pop
            stack.Pop(); //removes Solutions from stack
            Console.WriteLine($"The current size of the stack is: {stack.Size}"); //should display 2
            stack.Print(); //prints the stack after the second pop
            stack.Pop(); //removes Technology from stack
            Console.WriteLine($"The current size of the stack is: {stack.Size}"); //should display 1
            stack.Print(); //prints the stack after the third pop
            stack.Pop(); //removes Foothill from stack
            Console.WriteLine($"The current size of the stack is: {stack.Size}"); //should display 0
            stack.Print(); //displays an error message because stack is empty
            stack.Pop(); //should throw an InvalidOperationException since stack is empty
        }

        //Tests stack Print method by pushing and popping elements from the stack and checking if the correct elements in the correct order
        //are being displayed. Also checks if an error message is printed when the stack is empty
        private static void TestStackPrintMethod()
        {
            var stack = new Stack<int>();
            stack.Print(); //tests if error message is displayed
            stack.Push(1);
            stack.Print(); //prints 1
            stack.Push(10);
            stack.Print(); //prints 1, 10
            stack.Push(100);
            stack.Print(); //prints 1, 10, 100
            stack.Pop();
            stack.Print(); //prints 1, 10
            stack.Pop();
            stack.Print(); //prints 1
            stack.Pop();
            stack.Print(); //displays an error message that stack is empty
        }

        //Tests stack Peak method by pushing and popping elements into/from the stack and calling Peak() to check that the correct element is being 
        //printed. Also tests if Peak throws an InavlidOperationException when stack is empty
        private static void TestStackPeakMethod()
        {
            var stack = new Stack<string>();
            stack.Push("Foothill");
            stack.Push("Technology");
            stack.Push("Solutions");
            stack.Print(); //prints stack contents
            stack.Peak(); //to test if the value printed matches the last value in the previous call
            stack.Print(); //print again to check that peak only prints the element and does not remove it
            stack.Pop(); //remove top element
            stack.Print(); //print new contents
            stack.Peak(); //peak to the new top element
            stack.Print(); //print again to confirm that peak did not remove the element
            stack.Pop(); //remove top element
            stack.Print();
            stack.Peak();
            stack.Print();
            stack.Pop(); //stack should be empty now
            stack.Print(); //should print error message
            stack.Peak(); //should throw InvalidOperationException
        }

        //Tests stack Clear() method by creating an empty stack, adding elements to it, then clearing the stack and checking if it is indeed empty 
        //by invoking Print to see if an error message is displayed.
        private static void TestStackClearMethod()
        {
            var stack = new Stack<bool>();
            stack.Push(true);
            stack.Push(false);
            stack.Push(false);
            stack.Push(true);
            stack.Print(); //print stack after elements were added
            stack.Clear(); //clear stack elements
            stack.Print(); //checks if stack was emptied. An error message should be displayed if Clear works
            stack.Clear(); //attempt to clear an empty stack. Error message should be displayed
        }
    }
}
