using System;
using Xunit;
using Stack_Classes;

namespace Test_Classes
{
    public class StackTests
    {
        [Fact]
        public void TestPushValid()
        {
            //arrange
            var stack = new Stack<double>();
            var expected = true;

            //act
            var actual = stack.Push(19.5);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestClearValid(){
            //arrange
            var stack = new Stack<String>();
            stack.Push("Foothill Technology");
            stack.Push("Solutions");
            var expected = true;

            //act
            var actual = stack.Clear();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestClearInvalid(){
            //arrange
            var stack = new Stack<String>();
            var expected = false;

            //act
            var actual = stack.Clear();

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestPeakValid(){
            //arrange
            var stack = new Stack<String>();
            stack.Push("Foothill Technology");
            stack.Push("Solutions");
            var expected = true;

            //act
            var actual = stack.Peak();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPeakInvalid(){
            //arrange
            var stack = new Stack<String>();
            var expected = false;

            //act
            var actual = stack.Peak();

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestPopValidOnlyOneElementInStack(){
            //arrange
            var stack = new Stack<double>();
            stack.Push(18.9);
            var expected = 18.9;

            //act
            var actual = stack.Pop();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPopValidMultipleElementsInStack(){
            //arrange
            var stack = new Stack<double>();
            stack.Push(18.9);
            stack.Push(100);
            stack.Push(1.798);
            var expected = 1.798;

            //act
            var actual = stack.Pop();

            //assert
            Assert.Equal(expected, actual);
        }

    }
}
