using DependencyInjectionTest;
using System;
using Xunit;

namespace UnitTests
{
    public class CalculatorTests
    {
        [Theory] 
        [InlineData(1, 2, 3)]
        [InlineData(1, 0, 1)]
        [InlineData(1, -2, -1)]
        public void Add_WhenGivenCorrectData_ShouldReturnSum(int numberOne, int numberTwo, int expectedSum)
        {
            //  Arrange
            var calculator = new Calculator();
            
            //  Act
            var sum = calculator.Add(numberOne, numberTwo);

            // Assert
            Assert.Equal(expectedSum, sum);

        }
    }
}
