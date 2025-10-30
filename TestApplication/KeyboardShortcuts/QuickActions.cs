// Exercise 2: Quick Actions
// Practice: Ctrl + . (dot), Alt + Enter, Ctrl + K + Ctrl + D

namespace TestApplication.KeyboardShortcuts
{
    // This class demonstrates Quick Actions and code formatting
    // TASKS:
    // 1. Use Ctrl + . to add missing using statements
    // 2. Use Ctrl + . to implement interfaces
    // 3. Use Ctrl + . to generate methods
    // 4. Use Ctrl + K, Ctrl + D to format the document
    // 5. Use Alt + Enter for lightbulb quick fixes
    
    // TASK: Implement this interface using Ctrl + .
    public interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        double Divide(int a, int b);
    }

    // TASK: Place cursor on class name, press Ctrl + ., select "Implement interface"
    public class QuickActionsCalculator : ICalculator
    {
        // Interface methods will be generated here
    }

    public class QuickActionsDemo
    {
        // TASK: This code is poorly formatted. Press Ctrl + K, Ctrl + D to format it
        public void PoorlyFormattedMethod(){
        int x=5;
        int y=10;
            int z=x+y;
        Console.WriteLine($"Result: {z}");}

        // TASK: Use Ctrl + . to generate this method
        public void CallNonExistentMethod()
        {
            // Place cursor on HelperMethod and press Ctrl + .
            HelperMethod("test");
        }

        // TASK: Use Ctrl + . to add null check
        public void ProcessString(string input)
        {
            // Place cursor on 'input' and use Ctrl + . to add null check
            int length = input.Length;
            Console.WriteLine($"Length: {length}");
        }

        // TASK: Use Ctrl + . to convert to expression body
        public int GetValue()
        {
            return 42;
        }

        // TASK: Use Ctrl + . to introduce constant
        public void UsesMagicNumber()
        {
            int timeout = 5000; // Place cursor on 5000, use Ctrl + . to extract constant
            Thread.Sleep(timeout);
        }

        // TASK: Use Ctrl + . to add using statement for missing namespace
        public void UseDateTimeOffset()
        {
            var now = DateTimeOffset.Now;
            Console.WriteLine(now);
        }

        // TASK: Use Alt + Enter to suppress warning
        public void MethodWithWarning()
        {
            var unused = "This variable is never used"; // Alt + Enter to suppress
        }

        // TASK: Use Ctrl + . to convert to LINQ
        public List<int> FilterEvenNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    result.Add(num);
                }
            }
            return result;
        }

        // TASK: Use Ctrl + . to add constructor parameter
        private readonly string _name;
        
        // Place cursor on _name above, use Ctrl + . to add to constructor
    }

    // TASK: Use Ctrl + . to generate equals and GetHashCode
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        
        // Right-click in class, use Ctrl + . to generate Equals and GetHashCode
    }
}
