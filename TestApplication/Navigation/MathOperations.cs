// Exercise 5: Advanced Navigation - Math Operations
// Practice: Ctrl + T, Ctrl + Shift + T, Ctrl + Tab

namespace TestApplication.Navigation
{
    // TASK: Close this file, then press Ctrl + Shift + T to reopen it
    // TASK: Press Ctrl + Tab to cycle between open files
    
    public static class MathOperations
    {
        // TASK: Use Ctrl + T and type "M:Power" to find this method
        public static int Power(int baseNum, int exponent)
        {
            if (exponent == 0) return 1;
            if (exponent == 1) return baseNum;
            
            int result = baseNum;
            for (int i = 1; i < exponent; i++)
            {
                result *= baseNum;
            }
            return result;
        }

        // TASK: Find all references to this method using Shift + F12
        public static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        // TASK: Use Alt + F12 to peek at this method's implementation
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int LeastCommonMultiple(int a, int b)
        {
            return (a * b) / GreatestCommonDivisor(a, b);
        }

        // TASK: Use Ctrl + K, Ctrl + T to see the call hierarchy
        public static double Average(params int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            return numbers.Sum() / (double)numbers.Length;
        }

        public static int Max(params int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Array cannot be empty");
            return numbers.Max();
        }

        public static int Min(params int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Array cannot be empty");
            return numbers.Min();
        }

        // TASK: Navigate to StringHelpers using Ctrl + T
        public static string FormatNumber(int number)
        {
            return StringHelpers.FormatWithCommas(number);
        }
    }

    // TASK: Practice navigation between nested classes
    public class AdvancedMath
    {
        public class Statistics
        {
            // TASK: Use breadcrumb navigation to see class hierarchy
            public static double Median(int[] numbers)
            {
                var sorted = numbers.OrderBy(n => n).ToArray();
                int mid = sorted.Length / 2;
                
                if (sorted.Length % 2 == 0)
                    return (sorted[mid - 1] + sorted[mid]) / 2.0;
                else
                    return sorted[mid];
            }

            public static double StandardDeviation(int[] numbers)
            {
                double avg = numbers.Average();
                double sumOfSquares = numbers.Sum(n => Math.Pow(n - avg, 2));
                return Math.Sqrt(sumOfSquares / numbers.Length);
            }
        }

        public class Geometry
        {
            // TASK: Use Ctrl + T with "M:CalculateCircleArea" to find this
            public static double CalculateCircleArea(double radius)
            {
                return Math.PI * radius * radius;
            }

            public static double CalculateCircleCircumference(double radius)
            {
                return 2 * Math.PI * radius;
            }

            public static double CalculateRectangleArea(double width, double height)
            {
                return width * height;
            }

            public static double CalculateTriangleArea(double baseLength, double height)
            {
                return 0.5 * baseLength * height;
            }
        }
    }

    // TASK: Use "Go to All" (Ctrl + T) to quickly switch between files
    public class MathOperationsTests
    {
        public static void RunTests()
        {
            Console.WriteLine("=== Math Operations Tests ===");
            
            // Test Power
            Console.WriteLine($"2^3 = {MathOperations.Power(2, 3)}");
            
            // Test Factorial
            Console.WriteLine($"5! = {MathOperations.Factorial(5)}");
            
            // Test IsPrime
            Console.WriteLine($"Is 17 prime? {MathOperations.IsPrime(17)}");
            
            // Test GCD
            Console.WriteLine($"GCD(48, 18) = {MathOperations.GreatestCommonDivisor(48, 18)}");
            
            // Test Average
            Console.WriteLine($"Average of [1,2,3,4,5] = {MathOperations.Average(1, 2, 3, 4, 5)}");
            
            // Test Statistics
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"Median = {AdvancedMath.Statistics.Median(data)}");
            Console.WriteLine($"Std Dev = {AdvancedMath.Statistics.StandardDeviation(data):F2}");
            
            // Test Geometry
            Console.WriteLine($"Circle Area (r=5) = {AdvancedMath.Geometry.CalculateCircleArea(5):F2}");
        }
    }
}
