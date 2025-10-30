// Unit tests for Calculator class
// To use Live Unit Testing (Enterprise only):
// 1. Test > Live Unit Testing > Start
// 2. Watch green/red indicators appear in Calculator.cs as you edit

using Xunit;

namespace TestApplication.BestPractices
{
    /// <summary>
    /// Unit tests for Calculator class
    /// Install xUnit to run these tests:
    /// - Install-Package xunit
    /// - Install-Package xunit.runner.visualstudio
    /// </summary>
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            // Arrange & Act
            int result = _calculator.Add(-5, -3);

            // Assert
            Assert.Equal(-8, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange & Act
            int result = _calculator.Subtract(10, 4);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Arrange & Act
            int result = _calculator.Multiply(6, 7);

            // Assert
            Assert.Equal(42, result);
        }

        [Fact]
        public void Divide_ValidNumbers_ReturnsQuotient()
        {
            // Arrange & Act
            double result = _calculator.Divide(10, 2);

            // Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            // Arrange, Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }

        [Fact]
        public void IsEven_EvenNumber_ReturnsTrue()
        {
            // Arrange & Act
            bool result = _calculator.IsEven(4);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEven_OddNumber_ReturnsFalse()
        {
            // Arrange & Act
            bool result = _calculator.IsEven(5);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Factorial_Zero_ReturnsOne()
        {
            // Arrange & Act
            int result = _calculator.Factorial(0);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Factorial_PositiveNumber_ReturnsFactorial()
        {
            // Arrange & Act
            int result = _calculator.Factorial(5);

            // Assert
            Assert.Equal(120, result); // 5! = 5*4*3*2*1 = 120
        }

        [Fact]
        public void Factorial_NegativeNumber_ThrowsException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => _calculator.Factorial(-1));
        }

        // NOTE: Modulo method has no tests - will show blue dash in Live Unit Testing
    }
}
