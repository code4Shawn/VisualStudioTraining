// Exercise 5: Advanced Navigation - String Helpers
// Practice: Code Lens, Find All References, Peek Definition

namespace TestApplication.Navigation
{
    // TASK: Enable Code Lens (Options > Text Editor > All Languages > Code Lens)
    // Hover over methods to see reference counts and test status
    
    public static class StringHelpers
    {
        // TASK: Hover to see Code Lens showing how many times this is referenced
        public static string FormatWithCommas(int number)
        {
            return number.ToString("N0");
        }

        // TASK: Use Shift + F12 to find all references
        public static string Capitalize(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }

        // TASK: Use Alt + F12 to peek at implementation
        public static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
            
            string cleaned = input.ToLower().Replace(" ", "");
            return cleaned == Reverse(cleaned).ToLower();
        }

        public static int CountWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;
            
            return input.Split(new[] { ' ', '\t', '\n', '\r' }, 
                StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string TruncateWithEllipsis(string input, int maxLength)
        {
            if (string.IsNullOrEmpty(input) || input.Length <= maxLength)
                return input;
            
            return input.Substring(0, maxLength - 3) + "...";
        }

        // TASK: Use Ctrl + K, Ctrl + T to see call hierarchy
        public static string RemoveSpecialCharacters(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            
            return new string(input.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray());
        }

        public static string ToTitleCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            
            var words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = Capitalize(words[i]);
                }
            }
            return string.Join(" ", words);
        }

        public static string ExtractNumbers(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;
            
            return new string(input.Where(char.IsDigit).ToArray());
        }

        public static bool ContainsOnlyDigits(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
            
            return input.All(char.IsDigit);
        }
    }

    // TASK: Practice navigation between related classes
    public class StringValidator
    {
        // TASK: Use F12 to navigate to StringHelpers methods
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            
            return email.Contains("@") && email.Contains(".");
        }

        public bool IsValidPhoneNumber(string phone)
        {
            string digits = StringHelpers.ExtractNumbers(phone);
            return digits.Length >= 10 && digits.Length <= 15;
        }

        public bool IsStrongPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;
            
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecial = password.Any(c => !char.IsLetterOrDigit(c));
            
            return hasUpper && hasLower && hasDigit && hasSpecial;
        }
    }

    // TASK: Use Ctrl + T to navigate between test classes
    public class StringHelpersTests
    {
        public static void RunTests()
        {
            Console.WriteLine("=== String Helpers Tests ===");
            
            // Test FormatWithCommas
            Console.WriteLine($"Format 1000000: {StringHelpers.FormatWithCommas(1000000)}");
            
            // Test Capitalize
            Console.WriteLine($"Capitalize 'hello': {StringHelpers.Capitalize("hello")}");
            
            // Test Reverse
            Console.WriteLine($"Reverse 'hello': {StringHelpers.Reverse("hello")}");
            
            // Test IsPalindrome
            Console.WriteLine($"Is 'racecar' palindrome? {StringHelpers.IsPalindrome("racecar")}");
            
            // Test CountWords
            Console.WriteLine($"Word count in 'Hello World Test': {StringHelpers.CountWords("Hello World Test")}");
            
            // Test TruncateWithEllipsis
            Console.WriteLine($"Truncate: {StringHelpers.TruncateWithEllipsis("This is a long string", 10)}");
            
            // Test ToTitleCase
            Console.WriteLine($"Title case: {StringHelpers.ToTitleCase("hello world from visual studio")}");
            
            // Test Validator
            var validator = new StringValidator();
            Console.WriteLine($"Valid email? {validator.IsValidEmail("test@example.com")}");
            Console.WriteLine($"Valid phone? {validator.IsValidPhoneNumber("123-456-7890")}");
            Console.WriteLine($"Strong password? {validator.IsStrongPassword("Test123!@#")}");
        }
    }

    // TASK: Practice using breadcrumb navigation with nested classes
    public class TextProcessing
    {
        public class Formatter
        {
            public static string FormatAsCurrency(decimal amount)
            {
                return $"${amount:N2}";
            }

            public static string FormatAsPercentage(double value)
            {
                return $"{value * 100:F2}%";
            }
        }

        public class Parser
        {
            public static int ParseInt(string input)
            {
                string digits = StringHelpers.ExtractNumbers(input);
                return int.TryParse(digits, out int result) ? result : 0;
            }

            public static List<string> ParseCsv(string csvLine)
            {
                return csvLine.Split(',').Select(s => s.Trim()).ToList();
            }
        }
    }
}
