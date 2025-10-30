// Exercise 1: Build and Run
// Practice: Ctrl + Shift + B, Ctrl + , E, F5, Ctrl + F5

namespace TestApplication.KeyboardShortcuts
{
    // This class has intentional errors for you to fix using keyboard shortcuts.
    // TASKS:
    // 1. Press Ctrl + Shift + B to build and see errors
    // 2. Press Ctrl + \, E to open Error List
    // 3. Fix the errors using Quick Actions (Ctrl + .)
    // 4. Press F5 to start debugging
    // 5. Press Ctrl + F5 to run without debugging
    
    public class BuildAndRun
    {
        // ERROR: Missing using statement for Console
        public void PrintMessage()
        {
            Console.WriteLine("Hello from BuildAndRun!");
        }

        // ERROR: Method returns int but no return statement
        public int Calculate()
        {
            int result = 10 + 20;
            // Fix: Add return statement
        }

        // ERROR: Variable declared but never used
        public void UnusedVariable()
        {
            int unusedVar = 42;
            Console.WriteLine("This method has an unused variable warning");
        }

        // TASK: Build this and fix all errors using Ctrl + . (Quick Actions)
        public void TestMethod()
        {
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            
            foreach (var name in names)
            {
                Console.WriteLine($"Name: {name}");
            }
        }

        // Entry point for testing
        public static void Main(string[] args)
        {
            var demo = new BuildAndRun();
            demo.PrintMessage();
            
            int result = demo.Calculate();
            Console.WriteLine($"Result: {result}");
            
            demo.TestMethod();
            
            // Press Ctrl + F5 to run without debugging
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
