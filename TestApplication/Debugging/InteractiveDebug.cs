// Exercise 9: Interactive Debugging
// Practice: Immediate Window, Edit and Continue, Autos/Locals windows

namespace TestApplication.Debugging
{
    // This class demonstrates interactive debugging features
    // TASKS:
    // 1. Use Immediate Window (Ctrl + Alt + I or Debug > Windows > Immediate)
    // 2. Evaluate expressions during debugging
    // 3. Modify variables on the fly
    // 4. Use Edit and Continue to change code while debugging
    // 5. Explore Autos and Locals windows
    
    public class InteractiveDebug
    {
        // TASK: Immediate Window Basics
        // 1. Set breakpoint in this method
        // 2. Start debugging (F5)
        // 3. Open Immediate Window (Ctrl + Alt + I)
        // 4. Type: ? x (to see value)
        // 5. Type: ? x + y (to evaluate expression)
        // 6. Type: x = 100 (to change value)
        // 7. Continue execution to see the change
        public static void ImmediateWindowBasics()
        {
            int x = 10;
            int y = 20;
            
            // Breakpoint here
            // In Immediate Window, try:
            // ? x
            // ? y
            // ? x + y
            // ? x * y
            // x = 50
            
            int sum = x + y;
            Console.WriteLine($"Sum: {sum}");  // Will show modified value if you changed x
        }

        // TASK: Immediate Window with Objects
        // In Immediate Window, try:
        // ? person
        // ? person.FirstName
        // ? person.GetFullName()
        // person.Age = 40
        // ? person.Age
        public static void ImmediateWindowObjects()
        {
            var person = new PersonDebug
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30
            };
            
            // Breakpoint here
            Console.WriteLine(person.GetFullName());
            Console.WriteLine($"Age: {person.Age}");
        }

        // TASK: Immediate Window with Collections
        // In Immediate Window, try:
        // ? numbers.Count
        // ? numbers[0]
        // ? numbers.Sum()
        // ? numbers.Average()
        // ? numbers.Where(n => n > 50).ToList()
        // numbers.Add(999)
        public static void ImmediateWindowCollections()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            
            // Breakpoint here
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        // TASK: Immediate Window - Call Methods
        // In Immediate Window, try:
        // ? HelperMethod(5, 10)
        // ? HelperMethod(100, 200)
        // You can call any method in scope!
        public static void ImmediateWindowMethods()
        {
            int a = 5;
            int b = 10;
            
            // Breakpoint here
            int result = HelperMethod(a, b);
            Console.WriteLine($"Result: {result}");
        }

        private static int HelperMethod(int x, int y)
        {
            return x * y + 10;
        }

        // TASK: Edit and Continue
        // 1. Set breakpoint in this method
        // 2. Start debugging
        // 3. When paused, edit the code (e.g., change the multiplier from 2 to 3)
        // 4. Continue execution (F5)
        // 5. The new code will run without restarting!
        // Note: Enable in Options > Debugging > General > Enable Edit and Continue
        public static void EditAndContinueDemo()
        {
            for (int i = 1; i <= 5; i++)
            {
                int result = i * 2;  // Breakpoint here - try changing 2 to 3 while debugging
                Console.WriteLine($"{i} * 2 = {result}");
            }
        }

        // TASK: Edit and Continue - Add Code
        // While debugging, you can add new lines of code
        // Try adding: Console.WriteLine($"Debug: x = {x}");
        public static void EditAndContinueAddCode()
        {
            int x = 10;
            
            // Breakpoint here
            // While paused, add a new Console.WriteLine above this line
            
            x = x * 2;
            Console.WriteLine($"Final x: {x}");
        }

        // TASK: Autos Window
        // Debug > Windows > Autos
        // Shows variables used in current and previous statements
        public static void AutosWindowDemo()
        {
            int a = 5;
            int b = 10;
            int c = a + b;  // Breakpoint here - Autos shows a, b, c
            
            int d = c * 2;  // Step here - Autos shows c, d
            int e = d - 5;  // Step here - Autos shows d, e
            
            Console.WriteLine($"Result: {e}");
        }

        // TASK: Locals Window
        // Debug > Windows > Locals
        // Shows all local variables in current scope
        public static void LocalsWindowDemo()
        {
            int x = 10;
            int y = 20;
            string message = "Hello";
            
            // Breakpoint here - Locals window shows all variables
            
            for (int i = 0; i < 3; i++)
            {
                int temp = i * 2;  // Locals shows i and temp
                Console.WriteLine(temp);
            }
        }

        // TASK: Modify variable in Locals/Autos
        // 1. Set breakpoint
        // 2. In Locals or Autos window, double-click a value
        // 3. Change it
        // 4. Continue execution
        public static void ModifyInLocals()
        {
            int counter = 0;
            
            for (int i = 0; i < 5; i++)
            {
                counter += i;  // Breakpoint here - modify 'counter' in Locals window
                Console.WriteLine($"Counter: {counter}");
            }
        }

        // TASK: Immediate Window - Complex Expressions
        // Try these in Immediate Window:
        // ? string.Join(", ", numbers)
        // ? numbers.OrderByDescending(n => n).ToList()
        // ? numbers.Select(n => n * 2).ToList()
        public static void ComplexExpressions()
        {
            List<int> numbers = new List<int> { 5, 2, 8, 1, 9 };
            
            // Breakpoint here
            Console.WriteLine("Numbers: " + string.Join(", ", numbers));
        }

        // TASK: Immediate Window - Create New Objects
        // In Immediate Window, try:
        // var newPerson = new PersonDebug { FirstName = "Jane", LastName = "Smith", Age = 25 }
        // ? newPerson.GetFullName()
        public static void CreateObjectsInImmediate()
        {
            var person = new PersonDebug { FirstName = "John", LastName = "Doe", Age = 30 };
            
            // Breakpoint here
            // Create new objects in Immediate Window
            
            Console.WriteLine(person.GetFullName());
        }

        // TASK: Immediate Window - Exception Inspection
        // When exception occurs, use Immediate Window to inspect:
        // ? ex.Message
        // ? ex.StackTrace
        // ? ex.InnerException
        public static void InspectException()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                int value = numbers[10];  // Will throw exception
            }
            catch (Exception ex)
            {
                // Breakpoint here
                // Inspect exception in Immediate Window
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // TASK: Set Next Statement
        // 1. Set breakpoint
        // 2. While debugging, right-click on a line
        // 3. Select "Set Next Statement" (Ctrl + Shift + F10)
        // 4. This skips or repeats code execution
        public static void SetNextStatementDemo()
        {
            int x = 10;
            
            // Breakpoint here
            x = x + 5;  // You can skip this line using Set Next Statement
            
            x = x * 2;  // Or jump directly here
            
            Console.WriteLine($"x = {x}");
        }

        // TASK: Run to Click
        // While debugging, hover over a line and click the "Run to Click" icon
        // Execution continues to that line without setting a breakpoint
        public static void RunToClickDemo()
        {
            for (int i = 0; i < 10; i++)
            {
                // Breakpoint here
                Console.WriteLine($"i = {i}");
                
                if (i == 5)
                {
                    Console.WriteLine("Reached 5!");  // Use Run to Click to jump here
                }
            }
        }
    }

    public class PersonDebug
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }

    // TASK: Run all interactive debugging exercises
    public class InteractiveDebugRunner
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Interactive Debugging Exercises ===\n");
            
            // Uncomment one at a time to practice
            InteractiveDebug.ImmediateWindowBasics();
            // InteractiveDebug.ImmediateWindowObjects();
            // InteractiveDebug.ImmediateWindowCollections();
            // InteractiveDebug.ImmediateWindowMethods();
            // InteractiveDebug.EditAndContinueDemo();
            // InteractiveDebug.EditAndContinueAddCode();
            // InteractiveDebug.AutosWindowDemo();
            // InteractiveDebug.LocalsWindowDemo();
            // InteractiveDebug.ModifyInLocals();
            // InteractiveDebug.ComplexExpressions();
            // InteractiveDebug.CreateObjectsInImmediate();
            // InteractiveDebug.InspectException();
            // InteractiveDebug.SetNextStatementDemo();
            // InteractiveDebug.RunToClickDemo();
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
