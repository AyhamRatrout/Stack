using System;
using Xunit;
using Stack_Classes;
//using Microsoft.VisualStudio.Tes

namespace Test_Classes
{
    public class StackTests
    {
        //Tests that the Push method does indeed puh elements into the stack by checking the size of the stack after each push  
        //which should get incremented by one after each push starting from zero when the stack is first instantiated
        [Fact]
        public void TestThatPushChangesStackSizeByAddingElements()
        {
            //arrange
            var stack = new Stack<string>();

            //act
            var actual0 = stack.Size;
            stack.Push("Foothill");
            var actual1 = stack.Size;
            stack.Push("Technology");
            var actual2 = stack.Size;
            stack.Push("Solutions");
            var actual3 = stack.Size;

            //assert
            Assert.Equal(0, actual0);
            Assert.Equal(1, actual1);
            Assert.Equal(2, actual2);
            Assert.Equal(3, actual3);
        }

        //Tests that the Pop method does indeed pop the right elements in the correct order by comparing the value of the element being popped with the expected 
        //value as well as checking that the size of the stack gets decremented by one with each pop until the size reaches zero
        [Fact]
        public void TestThatPopMethodPopsTheCorrectElementAndDecreasesStackSizeForValidOperation()
        {
            //arrange
            var stack = new Stack<double>();
            var item1 = 10.5;
            var item2 = 17.3;
            var item3 = 0.71;
            stack.Push(item1);
            stack.Push(item2);
            stack.Push(item3);

            //act
            var actual1 = stack.Pop();
            var size1 = stack.Size;
            var actual2 = stack.Pop();
            var size2 = stack.Size;
            var actual3 = stack.Pop();
            var size3 = stack.Size;

            //assert
            Assert.Equal(2, size1);
            Assert.Equal(1, size2);
            Assert.Equal(0, size3);
            Assert.Equal(item3, actual1);
            Assert.Equal(item2, actual2);
            Assert.Equal(item1, actual3);
        }

        //Tests that Pop method throws an InvalidOperationException with the message provided when asked to pop from an empty stack
        [Fact]
        public void TestPopForInvalidOperation()
        {
            //arrange
            var stack = new Stack<int>();
            var expected = "Invalid operation! Cannot remove from an empty stack...";

            //act
            var actual = Assert.Throws<InvalidOperationException>(() => stack.Pop());

            //assert
            Assert.Equal(expected, actual.Message);
        }  

        //Tests that the Peak method does indeed print the object on the top of the stack without removing it by instantiating an empty stack, adding a number of elements to it
        //then peaking using Peak(), and popping after every peak to test multiple cases
        [Fact]
        public void TestPeakMethodReturnsTopElementValid()
        {
            //arrange
            var stack = new Stack<string>();
            stack.Push("Foothill");
            stack.Push("Technology");
            stack.Push("Solutions");

            //act
            var actual1 = stack.Peak();
            stack.Pop();
            var actual2 = stack.Peak();
            stack.Pop();
            var actual3 = stack.Peak();

            //assert
            Assert.Equal("Solutions", actual1);
            Assert.Equal("Technology", actual2);
            Assert.Equal("Foothill", actual3);
        }  

        //Tests that Peak method throws an InvalidOperationException with the message provided when asked to peak on an empty stack
        [Fact]
        public void TestPeakMethodThrowsAnExceptionInvalid()
        {
            //arrange
            var stack = new Stack<int>();
            var expected = "Invalid operation! Cannot retrieve the top item of empty stack...";

            //act
            var actual = Assert.Throws<InvalidOperationException>(() => stack.Peak());

            //assert
            Assert.Equal(expected, actual.Message);
        }
    }
}
