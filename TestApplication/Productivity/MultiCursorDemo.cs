// Exercise 13: Multi-Cursor Editing
// Practice: Ctrl + Alt + Click, Alt + Shift + . (next occurrence), Alt + Shift + ; (all occurrences)

namespace TestApplication.Productivity
{
    // This class demonstrates multi-cursor editing
    // TASKS:
    // 1. Ctrl + Alt + Click to place multiple cursors
    // 2. Alt + Shift + . to select next occurrence
    // 3. Alt + Shift + ; to select all occurrences
    // 4. Edit multiple locations simultaneously
    
    public class MultiCursorDemo
    {
        // TASK: Multi-cursor with Ctrl + Alt + Click
        // 1. Hold Ctrl + Alt
        // 2. Click at the start of each variable name below
        // 3. Type "new" to add prefix to all at once
        
        public void MultiCursorBasics()
        {
            string firstName = "John";
            string lastName = "Doe";
            string middleName = "Michael";
            string nickName = "Johnny";
            
            // Try adding "var " before each variable
            // Or change all "Name" to "Value"
        }

        // TASK: Select Next Occurrence (Alt + Shift + .)
        // 1. Place cursor on "value" below
        // 2. Press Alt + Shift + . repeatedly
        // 3. Each press selects the next occurrence
        // 4. Type to replace all selected occurrences
        
        public void SelectNextOccurrence()
        {
            int value = 10;
            int value2 = value + 5;
            int value3 = value * 2;
            int result = value + value2 + value3;
            
            // Select "value" and use Alt + Shift + . to select next occurrences
            // Try changing all "value" to "number"
        }

        // TASK: Select All Occurrences (Alt + Shift + ;)
        // 1. Place cursor on "temp" below
        // 2. Press Alt + Shift + ;
        // 3. All occurrences are selected
        // 4. Type to replace all at once
        
        public void SelectAllOccurrences()
        {
            int temp = 5;
            temp = temp + 10;
            temp = temp * 2;
            Console.WriteLine(temp);
            
            // Select "temp" and press Alt + Shift + ; to select all
            // Change "temp" to "result"
        }

        // TASK: Multi-cursor for adding prefixes
        // Use Ctrl + Alt + Click to place cursors before each property
        // Type "public " to add access modifier to all
        
        public void AddPrefixes()
        {
            // Add "public " before each property
            string Name { get; set; }
            int Age { get; set; }
            string Email { get; set; }
            DateTime BirthDate { get; set; }
        }

        // TASK: Multi-cursor for adding suffixes
        // Place cursors at the end of each line
        // Type "; // TODO: Validate" to add comment to all
        
        public void AddSuffixes()
        {
            string name = "John"
            int age = 30
            string email = "john@example.com"
            
            // Add semicolons and comments to all lines
        }

        // TASK: Multi-cursor for wrapping
        // Select multiple lines
        // Use Ctrl + Alt + Click to place cursors
        // Add quotes or brackets around values
        
        public void WrapValues()
        {
            var items = new[]
            {
                Item1,
                Item2,
                Item3,
                Item4
            };
            
            // Wrap each item in quotes: "Item1", "Item2", etc.
        }

        // TASK: Multi-cursor for alignment
        // Use multi-cursor to align variable declarations
        
        public void AlignDeclarations()
        {
            int x = 10;
            int longerVariableName = 20;
            int y = 30;
            int anotherLongName = 40;
            
            // Use multi-cursor to align the = signs
        }

        // TASK: Multi-cursor for method calls
        // Add Console.WriteLine to multiple variables
        
        public void AddMethodCalls()
        {
            string firstName = "John";
            string lastName = "Doe";
            int age = 30;
            string city = "New York";
            
            // Use multi-cursor to add Console.WriteLine($"{variableName}: {value}"); after each
        }

        // TASK: Multi-cursor for commenting
        // Use Ctrl + Alt + Click at the start of each line
        // Type "//" to comment all lines
        
        public void CommentMultipleLines()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            
            // Comment out all variable declarations
        }

        // TASK: Multi-cursor for renaming
        // Select "oldName" and use Alt + Shift + ; to select all
        // Type "newName" to rename all occurrences
        
        public void RenameVariable()
        {
            string oldName = "test";
            Console.WriteLine(oldName);
            
            if (oldName != null)
            {
                oldName = oldName.ToUpper();
            }
            
            return oldName;
        }

        // TASK: Multi-cursor with box selection
        // Hold Alt + Shift and drag to create box selection
        // Useful for editing columns of text
        
        public void BoxSelection()
        {
            // Use Alt + Shift + Arrow keys to select a box
            // Then type to edit all lines in the selection
            
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int value4 = 40;
            int value5 = 50;
            
            // Try selecting the numbers column and changing them all
        }

        // PRACTICE AREA: Multi-cursor exercises
        public void PracticeArea()
        {
            // Exercise 1: Add "var " before each variable
            x = 10;
            y = 20;
            z = 30;
            
            // Exercise 2: Add semicolons at the end
            int a = 1
            int b = 2
            int c = 3
            
            // Exercise 3: Change all "item" to "element"
            var item = GetItem();
            ProcessItem(item);
            SaveItem(item);
            
            // Exercise 4: Add quotes around each word
            var words = new[] { Apple, Banana, Cherry, Date };
            
            // Exercise 5: Add Console.WriteLine for each variable
            string name = "John";
            int age = 30;
            string city = "NYC";
        }

        // TASK: Multi-cursor for array initialization
        // Add quotes and commas to create string array
        
        public void ArrayInitialization()
        {
            var fruits = new[]
            {
                Apple
                Banana
                Cherry
                Date
                Elderberry
            };
            
            // Convert to: "Apple", "Banana", etc.
        }

        // TASK: Multi-cursor for adding attributes
        // Add [Required] attribute to each property
        
        public class PersonModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
            
            // Add [Required] before each property using multi-cursor
        }

        // TASK: Multi-cursor for parameter lists
        // Add type annotations to parameters
        
        public void MethodWithParameters(name, age, email, city)
        {
            // Add "string " or "int " before each parameter
        }

        // TIPS:
        // - Ctrl + Alt + Click: Place cursor at specific locations
        // - Alt + Shift + .: Select next occurrence of current selection
        // - Alt + Shift + ;: Select all occurrences of current selection
        // - Alt + Shift + Arrow: Box selection (column editing)
        // - Esc: Exit multi-cursor mode
        // - Ctrl + U: Undo last cursor operation
    }

    // ADVANCED MULTI-CURSOR SCENARIOS
    public class AdvancedMultiCursor
    {
        // TASK: Refactor multiple similar lines
        public void RefactorSimilarCode()
        {
            // Original code with repetition
            Console.WriteLine("Processing item 1");
            Console.WriteLine("Processing item 2");
            Console.WriteLine("Processing item 3");
            Console.WriteLine("Processing item 4");
            
            // Use multi-cursor to convert to loop
            // Select "item X" in all lines and replace with {i}
        }

        // TASK: Add error handling to multiple methods
        public void AddErrorHandling()
        {
            // Use multi-cursor to wrap each line in try-catch
            var result1 = RiskyOperation1();
            var result2 = RiskyOperation2();
            var result3 = RiskyOperation3();
        }

        // TASK: Format JSON-like structure
        public void FormatData()
        {
            // Add quotes and commas to create proper JSON
            var data = new
            {
                name: John Doe
                age: 30
                email: john@example.com
                city: New York
            };
        }
    }
}
