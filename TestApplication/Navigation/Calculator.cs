// Exercise 5: Advanced Navigation - Calculator
// Practice: Ctrl + T, Alt + F12, Shift + F12, Ctrl + K + Ctrl + T

namespace TestApplication.Navigation
{
    // This class demonstrates advanced navigation features
    // TASKS:
    // 1. Press Ctrl + T and type "T:Calculator" to find this type
    // 2. Press Ctrl + T and type "M:Add" to find the Add method
    // 3. Use Alt + F12 (Peek Definition) on methods
    // 4. Use Shift + F12 (Find All References) on methods
    // 5. Use Ctrl + K, Ctrl + T (Call Hierarchy) on methods
    
    public class Calculator
    {
        private readonly ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        // TASK: Use Shift + F12 to find all references to this method
        public int Add(int a, int b)
        {
            _logger?.Log($"Adding {a} + {b}");
            return a + b;
        }

        // TASK: Use Alt + F12 (Peek Definition) to view this inline
        public int Subtract(int a, int b)
        {
            _logger?.Log($"Subtracting {a} - {b}");
            return a - b;
        }

        // TASK: Use Ctrl + K, Ctrl + T to see Call Hierarchy
        public int Multiply(int a, int b)
        {
            _logger?.Log($"Multiplying {a} * {b}");
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                _logger?.LogError("Division by zero attempted");
                throw new DivideByZeroException();
            }
            
            _logger?.Log($"Dividing {a} / {b}");
            return (double)a / b;
        }

        // TASK: Navigate to MathOperations class using Ctrl + T
        public int Power(int baseNum, int exponent)
        {
            return MathOperations.Power(baseNum, exponent);
        }

        // TASK: Use breadcrumb navigation at the top of the editor
        public int PerformComplexCalculation(int x, int y, int z)
        {
            int step1 = Add(x, y);
            int step2 = Multiply(step1, z);
            int step3 = Subtract(step2, x);
            return step3;
        }
    }

    public interface ILogger
    {
        void Log(string message);
        void LogError(string message);
    }

    // TASK: Use Ctrl + T to quickly navigate between these classes
    public class CalculatorTests
    {
        private Calculator _calculator;

        public void Setup()
        {
            _calculator = new Calculator(new ConsoleLogger());
        }

        // TASK: Use F12 on Add to jump to implementation
        public void TestAdd()
        {
            int result = _calculator.Add(5, 3);
            Console.WriteLine($"Add result: {result}");
        }

        // TASK: Use Alt + F12 to peek at Subtract implementation
        public void TestSubtract()
        {
            int result = _calculator.Subtract(10, 4);
            Console.WriteLine($"Subtract result: {result}");
        }

        // TASK: Use Shift + F12 on Multiply to see all usages
        public void TestMultiply()
        {
            int result = _calculator.Multiply(6, 7);
            Console.WriteLine($"Multiply result: {result}");
        }

        public void TestDivide()
        {
            double result = _calculator.Divide(20, 4);
            Console.WriteLine($"Divide result: {result}");
        }

        public void RunAllTests()
        {
            Setup();
            TestAdd();
            TestSubtract();
            TestMultiply();
            TestDivide();
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"[ERROR] {message}");
        }
    }
}
