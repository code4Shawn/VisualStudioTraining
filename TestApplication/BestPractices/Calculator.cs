// Example for Live Unit Testing demonstration
// This is a simple calculator class with unit tests

namespace TestApplication.BestPractices
{
    /// <summary>
    /// Simple calculator for demonstrating Live Unit Testing
    /// When Live Unit Testing is enabled (Enterprise only), you'll see:
    /// - Green checkmarks next to lines covered by passing tests
    /// - Red X marks next to lines covered by failing tests
    /// - Blue dashes next to lines not covered by tests
    /// </summary>
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;  // Will show green checkmark when test passes
        }

        public int Subtract(int a, int b)
        {
            return a - b;  // Will show green checkmark when test passes
        }

        public int Multiply(int a, int b)
        {
            return a * b;  // Will show green checkmark when test passes
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return (double)a / b;  // Will show green checkmark when test passes
        }

        public int Modulo(int a, int b)
        {
            return a % b;  // Will show blue dash if no test covers this
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;  // Will show indicator based on test coverage
        }

        public int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Number must be non-negative");
            
            if (n == 0 || n == 1)
                return 1;
            
            return n * Factorial(n - 1);
        }
    }
}
