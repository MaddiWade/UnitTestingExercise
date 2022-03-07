using System;
using System.Linq;
using UnitTestingExercise;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(10, 10, 0)]
        [InlineData(12, 7, 5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(10, 2, 20)]
        [InlineData(11, 3, 33)]
        [InlineData(1, 1, 1)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(6, 3, 2)]
        [InlineData(9,3,3)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
       
        public void IsOdd()
        {
            //Arrange
            var expected = new UnitTestMethods();
            //Act
            var actual = expected.IsOdd(1);
            //Assert
            actual.Equals(false);
        }

        [Fact]
        public void CanAdd()
        {
            //Arrange
            var expected = new UnitTestMethods();
            //Act
            var actual = expected.CanAdd(2, 2);
            //Assert
            Assert.Equal(4, actual);
           
        }
    }
}
