// Exercise 14: Surround With
// Practice: Ctrl + K + Ctrl + S

namespace TestApplication.Productivity
{
    // This class demonstrates "Surround With" functionality
    // TASKS:
    // 1. Select code
    // 2. Press Ctrl + K, Ctrl + S
    // 3. Choose from: if, for, foreach, while, try-catch, region, etc.
    
    public class SurroundWithDemo
    {
        // TASK: Surround with try-catch
        // 1. Select the code inside this method
        // 2. Press Ctrl + K, Ctrl + S
        // 3. Select "try"
        
        public void SurroundWithTryCatch()
        {
            int[] numbers = { 1, 2, 3 };
            int value = numbers[10];  // Select this line and surround with try-catch
            Console.WriteLine(value);
        }

        // TASK: Surround with if statement
        // Select the Console.WriteLine and surround with if
        
        public void SurroundWithIf(string input)
        {
            Console.WriteLine(input.ToUpper());  // Surround with: if (input != null)
        }

        // TASK: Surround with for loop
        // Select the Console.WriteLine and surround with for
        
        public void SurroundWithFor()
        {
            Console.WriteLine("Hello");  // Surround with for loop (0 to 5)
        }

        // TASK: Surround with foreach
        // Select the processing code and surround with foreach
        
        public void SurroundWithForEach()
        {
            var items = new List<string> { "A", "B", "C" };
            
            Console.WriteLine(item);  // Surround with foreach (var item in items)
        }

        // TASK: Surround with while
        // Select the code and surround with while loop
        
        public void SurroundWithWhile()
        {
            int counter = 0;
            
            Console.WriteLine(counter);  // Surround with while (counter < 10)
            counter++;
        }

        // TASK: Surround with region
        // Select multiple methods or properties and surround with #region
        
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2");
        }

        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        
        // Select all three methods above and surround with region "Helper Methods"

        // TASK: Surround with using statement
        // Select the file operations and surround with using
        
        public void SurroundWithUsing()
        {
            var stream = new FileStream("test.txt", FileMode.Create);
            stream.WriteByte(65);
            stream.Close();
            
            // Select all three lines and surround with using
        }

        // TASK: Surround with do-while
        
        public void SurroundWithDoWhile()
        {
            int x = 0;
            
            Console.WriteLine(x);  // Surround with do-while
            x++;
        }

        // TASK: Nested Surround With
        // First surround with if, then surround with try-catch
        
        public void NestedSurroundWith(string input)
        {
            string result = input.ToUpper();
            Console.WriteLine(result);
            
            // 1. Select both lines
            // 2. Surround with if (input != null)
            // 3. Select the if block
            // 4. Surround with try-catch
        }

        // PRACTICE AREA
        public void PracticeArea1()
        {
            // Exercise 1: Surround with try-catch
            int result = 10 / 0;
            Console.WriteLine(result);
        }

        public void PracticeArea2(List<int> numbers)
        {
            // Exercise 2: Surround with if (numbers != null && numbers.Count > 0)
            int sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");
        }

        public void PracticeArea3()
        {
            // Exercise 3: Surround with for loop (5 iterations)
            Console.WriteLine("Iteration");
        }

        public void PracticeArea4()
        {
            var items = new[] { "Apple", "Banana", "Cherry" };
            
            // Exercise 4: Surround with foreach
            Console.WriteLine(item);
        }

        public void PracticeArea5()
        {
            // Exercise 5: Surround with using
            var file = File.OpenRead("data.txt");
            var reader = new StreamReader(file);
            string content = reader.ReadToEnd();
            reader.Close();
            file.Close();
        }

        // TASK: Surround with custom snippet
        // You can create custom "Surround With" snippets
        // Tools > Code Snippets Manager > Import
        
        public void CustomSurroundWith()
        {
            Console.WriteLine("This could be surrounded with custom logic");
        }

        // TASK: Surround multiple statements
        // Select all variable declarations and surround with region
        
        public void MultipleStatements()
        {
            int x = 10;
            int y = 20;
            int z = 30;
            string name = "Test";
            bool isActive = true;
            
            // Select all variables and surround with region "Variables"
        }

        // TASK: Surround with lock (for thread safety)
        
        private readonly object _lockObject = new object();
        private int _sharedResource = 0;
        
        public void SurroundWithLock()
        {
            _sharedResource++;  // Surround with lock (_lockObject)
            Console.WriteLine(_sharedResource);
        }

        // TASK: Surround with checked (for overflow checking)
        
        public void SurroundWithChecked()
        {
            int maxValue = int.MaxValue;
            int result = maxValue + 1;  // Surround with checked
            Console.WriteLine(result);
        }

        // TASK: Surround with unchecked
        
        public void SurroundWithUnchecked()
        {
            int maxValue = int.MaxValue;
            int result = maxValue + 1;  // Surround with unchecked
            Console.WriteLine(result);
        }
    }

    // ADVANCED SURROUND WITH SCENARIOS
    public class AdvancedSurroundWith
    {
        // TASK: Surround with async/await pattern
        
        public void ConvertToAsync()
        {
            var data = DownloadData();  // Surround to make async
            ProcessData(data);
        }

        private string DownloadData()
        {
            return "data";
        }

        private void ProcessData(string data)
        {
            Console.WriteLine(data);
        }

        // TASK: Surround with null check pattern
        
        public void NullCheckPattern(string input)
        {
            var length = input.Length;  // Surround with if (input != null)
            var upper = input.ToUpper();
            Console.WriteLine($"{length}: {upper}");
        }

        // TASK: Surround with validation pattern
        
        public void ValidationPattern(int age)
        {
            Console.WriteLine($"Age: {age}");  // Surround with if (age >= 0 && age <= 120)
            ProcessAge(age);
        }

        private void ProcessAge(int age)
        {
            Console.WriteLine($"Processing age: {age}");
        }

        // TASK: Surround with logging pattern
        
        public void LoggingPattern()
        {
            var result = PerformOperation();  // Surround with try-catch and add logging
            Console.WriteLine(result);
        }

        private int PerformOperation()
        {
            return 42;
        }
    }

    // TIPS FOR SURROUND WITH:
    // - Ctrl + K, Ctrl + S: Open Surround With menu
    // - Common options: if, for, foreach, while, do, try, using, region
    // - Works with single lines or multiple selected lines
    // - Can be nested (surround already surrounded code)
    // - Custom snippets can be created for Surround With
    // - Right-click > Snippet > Surround With (alternative to keyboard)
}
