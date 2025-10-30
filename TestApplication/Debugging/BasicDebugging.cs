// Exercise 7: Basic Debugging
// Practice: F9, F5, F10, F11, Shift + F11, DataTips

namespace TestApplication.Debugging
{
    // This class demonstrates basic debugging techniques
    // TASKS:
    // 1. Set breakpoints with F9
    // 2. Start debugging with F5
    // 3. Step Over with F10
    // 4. Step Into with F11
    // 5. Step Out with Shift + F11
    // 6. Hover over variables to see DataTips
    // 7. Pin DataTips for persistence
    
    public class BasicDebugging
    {
        // TASK: Set a breakpoint on the first line of this method (F9)
        // Then start debugging (F5)
        public static void SimpleCalculation()
        {
            int x = 10;  // Breakpoint here - hover to see value in DataTip
            int y = 20;  // Step over (F10) to here
            int sum = x + y;  // Hover over 'sum' to see result
            int product = x * y;
            
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
        }

        // TASK: Practice Step Into (F11) vs Step Over (F10)
        public static void CallMethods()
        {
            Console.WriteLine("Starting method calls");
            
            // Set breakpoint here
            int result1 = AddNumbers(5, 3);  // Press F11 to step INTO this method
            
            int result2 = MultiplyNumbers(4, 6);  // Press F10 to step OVER this method
            
            int result3 = SubtractNumbers(10, 4);
            
            Console.WriteLine($"Results: {result1}, {result2}, {result3}");
        }

        // TASK: Step into this method with F11
        private static int AddNumbers(int a, int b)
        {
            int result = a + b;  // Once inside, hover over variables
            return result;  // Press Shift + F11 to step OUT
        }

        private static int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }

        private static int SubtractNumbers(int a, int b)
        {
            return a - b;
        }

        // TASK: Debug a loop - watch variable changes
        public static void DebugLoop()
        {
            int total = 0;
            
            // Set breakpoint here
            for (int i = 0; i < 5; i++)
            {
                total += i;  // Hover over 'total' and 'i' to see values change
                Console.WriteLine($"Iteration {i}: total = {total}");
                // Pin the DataTip for 'total' to track it across iterations
            }
            
            Console.WriteLine($"Final total: {total}");
        }

        // TASK: Debug with collections
        public static void DebugCollections()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            
            // Set breakpoint here
            // Hover over 'numbers' to expand and see all items
            foreach (int num in numbers)
            {
                int squared = num * num;
                Console.WriteLine($"{num} squared = {squared}");
                // Hover over 'num' and 'squared' to see values
            }
        }

        // TASK: Debug with objects
        public static void DebugObjects()
        {
            var person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30
            };
            
            // Set breakpoint here
            // Hover over 'person' to expand and see all properties
            string fullName = person.GetFullName();
            
            // Hover over 'fullName' to see result
            Console.WriteLine(fullName);
        }

        // TASK: Debug nested method calls
        public static void DebugNestedCalls()
        {
            int x = 5;
            int y = 10;
            
            // Set breakpoint here
            // Use F11 to step into each nested call
            int result = CalculateComplex(x, y);
            
            Console.WriteLine($"Result: {result}");
        }

        private static int CalculateComplex(int a, int b)
        {
            int sum = AddNumbers(a, b);  // F11 to step into
            int product = MultiplyNumbers(sum, 2);  // F11 to step into
            return product;
        }

        // TASK: Debug with exception
        public static void DebugWithException()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                
                // Set breakpoint here
                for (int i = 0; i <= 5; i++)  // Will throw IndexOutOfRangeException
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            catch (Exception ex)
            {
                // Breakpoint here to inspect exception
                Console.WriteLine($"Error: {ex.Message}");
                // Hover over 'ex' to see exception details
            }
        }

        // TASK: Practice DataTips pinning
        public static void PinDataTips()
        {
            int counter = 0;
            
            // Set breakpoint here
            for (int i = 0; i < 3; i++)
            {
                counter += i;
                // Hover over 'counter', right-click DataTip, select "Pin to Source"
                // The pinned DataTip will persist across debug sessions
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }

    // TASK: Run all debugging exercises
    public class BasicDebuggingRunner
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Basic Debugging Exercises ===\n");
            
            // Uncomment one at a time to practice
            BasicDebugging.SimpleCalculation();
            // BasicDebugging.CallMethods();
            // BasicDebugging.DebugLoop();
            // BasicDebugging.DebugCollections();
            // BasicDebugging.DebugObjects();
            // BasicDebugging.DebugNestedCalls();
            // BasicDebugging.DebugWithException();
            // BasicDebugging.PinDataTips();
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
