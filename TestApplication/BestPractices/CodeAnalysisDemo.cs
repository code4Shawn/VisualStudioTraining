// Exercise 17: Code Analysis
// Practice: Roslyn analyzers, Quick Actions, .editorconfig

namespace TestApplication.BestPractices
{
    // This class demonstrates code analysis features
    // TASKS:
    // 1. Observe Roslyn analyzer warnings (green squiggles)
    // 2. Use Ctrl + . to see Quick Actions for fixes
    // 3. Configure .editorconfig for custom rules
    // 4. View Error List (Ctrl + \, E) filtered by severity
    
    public class CodeAnalysisDemo
    {
        // ISSUE: Unused private field (IDE0051)
        // Quick Action: Remove unused field
        private int _unusedField;

        // ISSUE: Field can be readonly (IDE0044)
        // Quick Action: Make readonly
        private string _name = "Test";

        // ISSUE: Use expression body (IDE0021)
        // Quick Action: Use expression body for method
        public int GetValue()
        {
            return 42;
        }

        // ISSUE: Use pattern matching (IDE0019)
        // Quick Action: Use pattern matching
        public void CheckType(object obj)
        {
            string str = obj as string;
            if (str != null)
            {
                Console.WriteLine(str);
            }
        }

        // ISSUE: Use var (IDE0007)
        // Quick Action: Use 'var' instead of explicit type
        public void UseVar()
        {
            string message = "Hello";
            int count = 10;
            List<string> items = new List<string>();
        }

        // ISSUE: Simplify LINQ expression (IDE0120)
        // Quick Action: Simplify LINQ
        public void SimplifyLinq()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var even = numbers.Where(n => n % 2 == 0).ToList();
        }

        // ISSUE: Use string interpolation (IDE0071)
        // Quick Action: Convert to string interpolation
        public void UseStringInterpolation()
        {
            string name = "John";
            int age = 30;
            string message = string.Format("Name: {0}, Age: {1}", name, age);
        }

        // ISSUE: Use collection initializer (IDE0028)
        // Quick Action: Use collection initializer
        public void UseCollectionInitializer()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
        }

        // ISSUE: Use object initializer (IDE0017)
        // Quick Action: Use object initializer
        public void UseObjectInitializer()
        {
            var person = new Person();
            person.Name = "John";
            person.Age = 30;
        }

        // ISSUE: Null check can be simplified (IDE0029)
        // Quick Action: Use coalesce expression
        public string GetNameOrDefault(string name)
        {
            return name != null ? name : "Default";
        }

        // ISSUE: Use conditional expression (IDE0045)
        // Quick Action: Convert to conditional expression
        public int GetAbsoluteValue(int value)
        {
            if (value < 0)
                return -value;
            else
                return value;
        }

        // ISSUE: Remove unnecessary cast (IDE0004)
        // Quick Action: Remove unnecessary cast
        public void UnnecessaryCast()
        {
            object obj = "Hello";
            string str = (string)obj;
            Console.WriteLine(str);
        }

        // ISSUE: Use compound assignment (IDE0054)
        // Quick Action: Use compound assignment
        public void UseCompoundAssignment()
        {
            int x = 10;
            x = x + 5;
            x = x * 2;
        }

        // ISSUE: Use index operator (IDE0056)
        // Quick Action: Use index operator
        public void UseIndexOperator()
        {
            var array = new[] { 1, 2, 3, 4, 5 };
            var last = array[array.Length - 1];
        }

        // ISSUE: Use range operator (IDE0057)
        // Quick Action: Use range operator
        public void UseRangeOperator()
        {
            var array = new[] { 1, 2, 3, 4, 5 };
            var subset = array.Skip(1).Take(3).ToArray();
        }

        // ISSUE: Simplify default expression (IDE0034)
        // Quick Action: Simplify default expression
        public void SimplifyDefault()
        {
            int value = default(int);
            string text = default(string);
        }

        // ISSUE: Use throw expression (IDE0016)
        // Quick Action: Use throw expression
        public Person CreatePerson(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            
            return new Person { Name = name };
        }

        // ISSUE: Inline variable (IDE0058)
        // Quick Action: Inline temporary variable
        public void InlineVariable()
        {
            int temp = GetValue();
            Console.WriteLine(temp);
        }

        // ISSUE: Use pattern matching (IDE0083)
        // Quick Action: Use pattern matching
        public void UsePatternMatching(object obj)
        {
            if (obj.GetType() == typeof(string))
            {
                var str = (string)obj;
                Console.WriteLine(str);
            }
        }

        // ISSUE: Simplify interpolation (IDE0071)
        // Quick Action: Simplify interpolation
        public void SimplifyInterpolation()
        {
            int value = 42;
            string message = $"Value: {value.ToString()}";
        }

        // ISSUE: Use discard (IDE0058)
        // Quick Action: Use discard
        public void UseDiscard()
        {
            var result = TryParse("123", out int value);
        }

        private bool TryParse(string input, out int value)
        {
            return int.TryParse(input, out value);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // PERFORMANCE ANALYSIS
    public class PerformanceIssues
    {
        // ISSUE: String concatenation in loop (CA1820)
        // Quick Action: Use StringBuilder
        public string ConcatenateInLoop()
        {
            string result = "";
            for (int i = 0; i < 100; i++)
            {
                result += i.ToString();
            }
            return result;
        }

        // ISSUE: Unnecessary boxing (CA1800)
        public void UnnecessaryBoxing()
        {
            int value = 42;
            object obj = value;
            Console.WriteLine(obj);
        }

        // ISSUE: Inefficient LINQ (CA1826)
        public void InefficientLinq()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var count = numbers.Where(n => n > 2).Count();
        }

        // ISSUE: Unnecessary allocation
        public void UnnecessaryAllocation()
        {
            var array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }
    }

    // SECURITY ISSUES
    public class SecurityIssues
    {
        // ISSUE: SQL injection vulnerability
        // Quick Action: Use parameterized query
        public void SqlInjectionRisk(string userInput)
        {
            string query = "SELECT * FROM Users WHERE Name = '" + userInput + "'";
            // Execute query - DANGEROUS!
        }

        // ISSUE: Path traversal vulnerability
        public void PathTraversalRisk(string fileName)
        {
            string path = "C:\\Data\\" + fileName;
            // File.ReadAllText(path) - DANGEROUS!
        }

        // ISSUE: Weak cryptography
        public void WeakCrypto()
        {
            // Using MD5 or SHA1 - WEAK!
        }
    }

    // MAINTAINABILITY ISSUES
    public class MaintainabilityIssues
    {
        // ISSUE: Method too long (CA1502)
        public void VeryLongMethod()
        {
            // 100+ lines of code
            // Should be refactored into smaller methods
        }

        // ISSUE: Too many parameters (CA1502)
        public void TooManyParameters(int a, int b, int c, int d, int e, int f, int g)
        {
            // Consider using a parameter object
        }

        // ISSUE: Cyclomatic complexity too high
        public void ComplexMethod(int value)
        {
            if (value > 0)
            {
                if (value < 10)
                {
                    if (value % 2 == 0)
                    {
                        // Too many nested conditions
                    }
                }
            }
        }
    }

    // TIPS FOR CODE ANALYSIS:
    // 1. Enable all analyzers in project properties
    // 2. Set severity levels in .editorconfig
    // 3. Use Ctrl + . to see and apply Quick Actions
    // 4. Review Error List regularly
    // 5. Configure custom rules for your team
    // 6. Use code analysis in CI/CD pipeline
    // 7. Suppress warnings only when necessary
    // 8. Document suppression reasons
}
