// Exercise 4: Editing Tricks
// Practice: Ctrl + Shift + L, Ctrl + D, Ctrl + Shift + V, Ctrl + Shift + F

namespace TestApplication.KeyboardShortcuts
{
    // This class demonstrates editing shortcuts
    // TASKS:
    // 1. Use Ctrl + Shift + L to delete lines
    // 2. Use Ctrl + D to duplicate lines
    // 3. Use Ctrl + Shift + V for clipboard history
    // 4. Use Ctrl + Shift + F to find in files
    
    public class EditingTricks
    {
        // TASK: Delete this line using Ctrl + Shift + L
        // DELETE ME: This line should be removed
        
        // TASK: Duplicate this line using Ctrl + D
        public void ImportantMethod() { }
        
        // TASK: Practice clipboard history
        // 1. Copy this line: var x = 1;
        // 2. Copy this line: var y = 2;
        // 3. Copy this line: var z = 3;
        // 4. Press Ctrl + Shift + V to cycle through clipboard history
        
        public void ClipboardHistoryDemo()
        {
            var x = 1;
            var y = 2;
            var z = 3;
            // Paste here using Ctrl + Shift + V to see history
        }

        // TASK: Use Ctrl + Shift + F to find all occurrences of "SearchMe" in the solution
        private const string SearchMe = "SearchMe";
        
        public void UseSearchTerm()
        {
            Console.WriteLine(SearchMe);
        }

        // TASK: Delete multiple lines quickly
        // Place cursor on each line and press Ctrl + Shift + L
        // DELETE LINE 1
        // DELETE LINE 2
        // DELETE LINE 3
        // DELETE LINE 4

        // TASK: Duplicate this entire method using Ctrl + D on each line
        public void DuplicateMe()
        {
            Console.WriteLine("Original method");
        }

        // TASK: Use Ctrl + Shift + F with regex
        // Search for: \b\d{3}\b (finds 3-digit numbers)
        public void ContainsNumbers()
        {
            int code1 = 123;
            int code2 = 456;
            int code3 = 789;
            int largeNumber = 12345; // Won't match
        }

        // TASK: Practice line manipulation
        // 1. Move lines up/down with Alt + Up/Down
        // 2. Delete lines with Ctrl + Shift + L
        // 3. Duplicate lines with Ctrl + D
        public void LineManiuplation()
        {
            // Move this line down
            var first = "First";
            
            // Move this line up
            var second = "Second";
            
            var third = "Third";
        }

        // TASK: Multi-line editing
        // 1. Select these lines
        // 2. Press Ctrl + K, Ctrl + C to comment
        // 3. Press Ctrl + K, Ctrl + U to uncomment
        public void CommentingPractice()
        {
            var line1 = "Comment me";
            var line2 = "Comment me too";
            var line3 = "And me";
        }

        // TASK: Use Ctrl + Shift + F to find and replace across files
        // Search for: OldVariableName
        // Replace with: NewVariableName
        private string OldVariableName = "test";
        
        public void UseOldVariable()
        {
            Console.WriteLine(OldVariableName);
        }

        // TASK: Practice selection shortcuts
        // Ctrl + A - Select all
        // Ctrl + W - Expand selection
        // Shift + Alt + Arrow - Box selection
        public void SelectionPractice()
        {
            var data = new[]
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4"
            };
        }

        // TASK: Delete word by word
        // Ctrl + Backspace - Delete word before cursor
        // Ctrl + Delete - Delete word after cursor
        public void WordDeletionPractice()
        {
            string longSentence = "This is a very long sentence that needs editing";
        }
    }

    // TASK: Find all classes that implement IDisposable using Ctrl + Shift + F
    public class DisposableResource : IDisposable
    {
        public void Dispose()
        {
            // Cleanup
        }
    }

    // TASK: Use Ctrl + H for find and replace in current file
    // Replace all instances of "OldName" with "NewName"
    public class OldName
    {
        public string OldName { get; set; }
        
        public void ProcessOldName()
        {
            var temp = new OldName();
        }
    }
}
