using System;

namespace Stack_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPushAndPrintMethods();
            Console.WriteLine("*******************************");
            TestClearMethod();
            Console.WriteLine("*******************************");
            TestPeakMethod();
            Console.WriteLine("*******************************");
            TestPopMethod();
            Console.WriteLine("*******************************");
            TestItAllTogether();
        }

        //Tests that the Push and Print Methods of the Stack class work. Test was successful!
        public static void TestPushAndPrintMethods(){
            var stack = new Stack<String>(); //creates a new stack instance
            stack.Print(); //to check if the error message does get displayed
            stack.Push("Foothill"); //pushes first string to stack
            stack.Print(); //prints contents of stack
            stack.Push("Technology"); //pushes another string to stack
            stack.Print(); //prints contents of stack
            stack.Push("Solutions"); //pushes string to stack
            stack.Push("Nablus"); //pushes string to stack
            stack.Print(); //prints the contents of the finalized stack
        }

        //Tests that the Clear method works as intended. Test was successful!
        public static void TestClearMethod(){
            var stack = new Stack<double>(); //creates a new stack
            stack.Clear(); //to test if the error message gets displayed
            stack.Push(19.7);
            stack.Push(50.3);
            stack.Print(); //prints the stack with elements in it
            stack.Clear(); //clears the stack
            stack.Clear();
            stack.Print(); //to check if the stack has actually been cleared
        }

        //Tests that the Peak method works as intended. Test was successful!
        public static void TestPeakMethod(){
            var stack = new Stack<int>();
            stack.Peak(); //checks if the error message gets displayed
            stack.Push(1);
            stack.Peak(); //displays the top element in the stack
            stack.Push(10);
            stack.Push(100);
            stack.Peak(); //to check if it works after multiple push operations.
            stack.Clear();
            stack.Peak();
        }

        //Tests that the Pop mwthod works as intended. Test was successful!
        public static void TestPopMethod(){
            var stack = new Stack<double>();
            stack.Push(19.7);
            stack.Print();
            stack.Pop(); //to check if it works for one element in stack
            stack.Print();
            stack.Push(50.7);
            stack.Push(72.04);
            stack.Print();
            stack.Pop(); //if it works for multiple elements in stack
            stack.Print();
            stack.Pop();
            stack.Print();
            stack.Pop(); //check if exception is thrown for inavlid scenario
        }

        //Tests that all the components work together for each case
        public static void TestItAllTogether(){
            var stack = new Stack<string>();
            //test the edge case when the stack is empty
            stack.Print();
            stack.Peak();
            stack.Clear();
            //test the case when one element is in the stack
            stack.Push("Cat");
            stack.Print();
            stack.Peak();
            stack.Pop();
            stack.Print();
            stack.Peak();
            stack.Push("Cat");
            stack.Print();
            stack.Peak();
            stack.Clear();
            stack.Print();
            stack.Peak();
            stack.Clear();
            //test with multiple elements
            stack.Push("Cat");
            stack.Push("Dog");
            stack.Push("Chipmunk");
            stack.Print();
            stack.Peak();
            stack.Clear();
            stack.Print();
            stack.Peak();
            stack.Clear();
            stack.Push("Cat");
            stack.Push("Dog");
            stack.Push("Chipmunk");
            stack.Print();
            stack.Peak();
            stack.Pop();
            stack.Print();
            stack.Peak();
            stack.Pop();
            stack.Print();
            stack.Peak();
            stack.Pop();
            stack.Print();
            stack.Peak();
            stack.Pop();



        }
    }
}
