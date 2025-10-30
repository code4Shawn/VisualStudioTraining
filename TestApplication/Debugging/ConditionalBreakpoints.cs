// Exercise 8: Advanced Breakpoints
// Practice: Conditional breakpoints, hit counts, Watch window, Exception settings

namespace TestApplication.Debugging
{
    // This class demonstrates advanced breakpoint techniques
    // TASKS:
    // 1. Set conditional breakpoints (right-click breakpoint glyph)
    // 2. Set hit count breakpoints
    // 3. Use Watch window to monitor expressions
    // 4. Configure Exception Settings (Ctrl + Alt + E)
    
    public class ConditionalBreakpoints
    {
        // TASK: Conditional Breakpoint Example
        // Set breakpoint on the Console.WriteLine line
        // Right-click breakpoint > Conditions > Conditional Expression
        // Enter: i > 5
        // The debugger will only break when i is greater than 5
        public static void ConditionalBreakpointDemo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i = {i}");  // Breakpoint with condition: i > 5
            }
        }

        // TASK: Multiple Conditions
        // Set breakpoint with condition: i % 2 == 0 && i > 3
        // Will only break on even numbers greater than 3
        public static void MultipleConditions()
        {
            for (int i = 0; i < 10; i++)
            {
                int squared = i * i;
                Console.WriteLine($"i = {i}, squared = {squared}");  // Conditional breakpoint here
            }
        }

        // TASK: Hit Count Breakpoint
        // Set breakpoint on Console.WriteLine
        // Right-click > Conditions > Hit Count
        // Set to "= 5" to break only on the 5th hit
        public static void HitCountDemo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Iteration {i}");  // Hit count breakpoint: = 5
            }
        }

        // TASK: Filter Breakpoint
        // Useful for multi-threaded applications
        // Right-click breakpoint > Conditions > Filter
        // Example: ThreadId = 1
        public static void FilterBreakpointDemo()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Processing {i}");  // Filter breakpoint here
            }
        }

        // TASK: Watch Window Practice
        // 1. Set breakpoint in this method
        // 2. Open Watch window (Debug > Windows > Watch > Watch 1)
        // 3. Add expressions: "numbers.Count", "numbers.Sum()", "total > 50"
        public static void WatchWindowDemo()
        {
            List<int> numbers = new List<int>();
            int total = 0;
            
            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
                total += i;
                // Breakpoint here - watch expressions in Watch window
                Console.WriteLine($"Added {i}, total = {total}");
            }
        }

        // TASK: Complex Watch Expressions
        // Add to Watch window:
        // - data.Count > 0
        // - data.Where(x => x > 50).Count()
        // - data.Average()
        // - data.Max() - data.Min()
        public static void ComplexWatchExpressions()
        {
            List<int> data = new List<int> { 10, 25, 50, 75, 100 };
            
            foreach (int value in data)
            {
                int doubled = value * 2;
                // Breakpoint here - add complex expressions to Watch
                Console.WriteLine($"Value: {value}, Doubled: {doubled}");
            }
        }

        // TASK: Conditional Breakpoint with String
        // Set condition: name.Contains("John")
        // Will only break when processing names containing "John"
        public static void StringConditionDemo()
        {
            string[] names = { "Alice", "John", "Bob", "Johnny", "Jane" };
            
            foreach (string name in names)
            {
                Console.WriteLine($"Processing: {name}");  // Condition: name.Contains("John")
            }
        }

        // TASK: Breakpoint with Object Property
        // Set condition: person.Age > 25
        public static void ObjectPropertyCondition()
        {
            var people = new[]
            {
                new PersonInfo { Name = "Alice", Age = 20 },
                new PersonInfo { Name = "Bob", Age = 30 },
                new PersonInfo { Name = "Charlie", Age = 25 },
                new PersonInfo { Name = "David", Age = 35 }
            };
            
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old");
                // Breakpoint with condition: person.Age > 25
            }
        }

        // TASK: Exception Settings
        // 1. Press Ctrl + Alt + E to open Exception Settings
        // 2. Check "Common Language Runtime Exceptions" to break on all exceptions
        // 3. Or check specific exceptions like "System.DivideByZeroException"
        public static void ExceptionSettingsDemo()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                
                // This will throw IndexOutOfRangeException
                // Configure Exception Settings to break when thrown
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught: {ex.Message}");
            }
        }

        // TASK: Break on Specific Exception
        // Configure to break only on NullReferenceException
        public static void SpecificExceptionDemo()
        {
            try
            {
                string text = null;
                int length = text.Length;  // Will throw NullReferenceException
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // TASK: Tracepoint (Action Breakpoint)
        // Right-click breakpoint > Actions
        // Enter message: "i = {i}, sum = {sum}"
        // Check "Continue execution"
        // This logs without stopping execution
        public static void TracepointDemo()
        {
            int sum = 0;
            
            for (int i = 1; i <= 5; i++)
            {
                sum += i;
                // Set tracepoint here to log values without breaking
            }
            
            Console.WriteLine($"Final sum: {sum}");
        }

        // TASK: Dependent Breakpoint
        // Set breakpoint on line A
        // Set another breakpoint on line B
        // Right-click line B breakpoint > Conditions > Only enable when other breakpoint is hit
        public static void DependentBreakpointDemo()
        {
            int x = 10;  // Breakpoint A
            
            for (int i = 0; i < 5; i++)
            {
                x += i;  // Breakpoint B (dependent on A)
                Console.WriteLine($"x = {x}");
            }
        }

        // TASK: Temporary Breakpoint
        // Right-click in margin > Insert Temporary Breakpoint (Ctrl + Shift + F9, T)
        // Breakpoint is automatically removed after first hit
        public static void TemporaryBreakpointDemo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Iteration {i}");
                // Insert temporary breakpoint here
            }
        }
    }

    public class PersonInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // TASK: Run all advanced breakpoint exercises
    public class ConditionalBreakpointsRunner
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Advanced Breakpoints Exercises ===\n");
            
            // Uncomment one at a time to practice
            ConditionalBreakpoints.ConditionalBreakpointDemo();
            // ConditionalBreakpoints.MultipleConditions();
            // ConditionalBreakpoints.HitCountDemo();
            // ConditionalBreakpoints.WatchWindowDemo();
            // ConditionalBreakpoints.ComplexWatchExpressions();
            // ConditionalBreakpoints.StringConditionDemo();
            // ConditionalBreakpoints.ObjectPropertyCondition();
            // ConditionalBreakpoints.ExceptionSettingsDemo();
            // ConditionalBreakpoints.SpecificExceptionDemo();
            // ConditionalBreakpoints.TracepointDemo();
            // ConditionalBreakpoints.DependentBreakpointDemo();
            // ConditionalBreakpoints.TemporaryBreakpointDemo();
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
