// Exercise 12: Code Snippets
// Practice: ctor, prop, propfull, for, foreach, try, if, class, interface

namespace TestApplication.Productivity
{
    // This class demonstrates code snippet usage
    // TASKS:
    // 1. Type snippet shortcut + Tab + Tab
    // 2. Fill in template fields
    // 3. Create custom snippets (Tools > Code Snippets Manager)
    
    // COMMON SNIPPETS TO PRACTICE:
    // ctor - Constructor
    // prop - Auto-property
    // propfull - Full property with backing field
    // for - For loop
    // foreach - Foreach loop
    // forr - Reverse for loop
    // while - While loop
    // do - Do-while loop
    // if - If statement
    // else - Else clause
    // switch - Switch statement
    // try - Try-catch
    // tryf - Try-finally
    // class - Class definition
    // interface - Interface definition
    // enum - Enum definition
    // struct - Struct definition
    // cw - Console.WriteLine
    // mbox - MessageBox.Show
    
    public class SnippetsDemo
    {
        // TASK: Type "propfull" + Tab + Tab
        // This creates a full property with backing field
        // Example result:
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        // TASK: Type "prop" + Tab + Tab
        // This creates an auto-property
        // Type the type, press Tab, type the name, press Enter
        // Example: prop > Tab > int > Tab > Age > Enter
        public int Age { get; set; }
        public string Name { get; set; }

        // TASK: Type "ctor" + Tab + Tab
        // This creates a constructor
        // The class name is automatically filled in
        public SnippetsDemo()
        {
            // Constructor body
        }

        // TASK: Type "for" + Tab + Tab
        // Creates a for loop
        public void ForLoopExample()
        {
            // Type: for > Tab > Tab
            // Then fill in: length > Tab > i
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        // TASK: Type "forr" + Tab + Tab
        // Creates a reverse for loop
        public void ReverseForLoop()
        {
            // Type: forr > Tab > Tab
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        // TASK: Type "foreach" + Tab + Tab
        // Creates a foreach loop
        public void ForEachExample()
        {
            var items = new List<string> { "A", "B", "C" };
            
            // Type: foreach > Tab > Tab
            // Fill in: var > Tab > item > Tab > items
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        // TASK: Type "while" + Tab + Tab
        public void WhileLoopExample()
        {
            int counter = 0;
            
            // Type: while > Tab > Tab
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }

        // TASK: Type "do" + Tab + Tab
        public void DoWhileExample()
        {
            int counter = 0;
            
            // Type: do > Tab > Tab
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 10);
        }

        // TASK: Type "if" + Tab + Tab
        public void IfStatementExample(int value)
        {
            // Type: if > Tab > Tab
            if (value > 0)
            {
                Console.WriteLine("Positive");
            }
        }

        // TASK: Type "switch" + Tab + Tab
        public void SwitchExample(int value)
        {
            // Type: switch > Tab > Tab
            switch (value)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }

        // TASK: Type "try" + Tab + Tab
        public void TryCatchExample()
        {
            // Type: try > Tab > Tab
            try
            {
                int result = 10 / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // TASK: Type "tryf" + Tab + Tab
        public void TryFinallyExample()
        {
            // Type: tryf > Tab > Tab
            try
            {
                // Code here
            }
            finally
            {
                // Cleanup here
            }
        }

        // TASK: Type "cw" + Tab + Tab
        // Quick Console.WriteLine
        public void ConsoleWriteLineShortcut()
        {
            // Type: cw > Tab > Tab
            Console.WriteLine("Quick console output");
        }
    }

    // TASK: Type "class" + Tab + Tab
    // Creates a new class
    // Type: class > Tab > Tab > ClassName > Enter
    public class NewClass
    {
        
    }

    // TASK: Type "interface" + Tab + Tab
    // Creates a new interface
    public interface INewInterface
    {
        
    }

    // TASK: Type "enum" + Tab + Tab
    // Creates a new enum
    public enum Status
    {
        Active,
        Inactive,
        Pending
    }

    // TASK: Type "struct" + Tab + Tab
    // Creates a new struct
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    // PRACTICE AREA: Delete the comments and practice typing snippets
    public class SnippetsPracticeArea
    {
        // Practice area - delete these comments and practice:
        
        // 1. Create a property using "prop"
        
        
        // 2. Create a full property using "propfull"
        
        
        // 3. Create a constructor using "ctor"
        
        
        // 4. Create a for loop using "for"
        
        
        // 5. Create a foreach loop using "foreach"
        
        
        // 6. Create an if statement using "if"
        
        
        // 7. Create a switch statement using "switch"
        
        
        // 8. Create a try-catch using "try"
        
        
        // 9. Create Console.WriteLine using "cw"
        
    }

    // CUSTOM SNIPPET CREATION
    // To create a custom snippet:
    // 1. Tools > Code Snippets Manager
    // 2. Click "Import" to add a .snippet file
    // 3. Or create one manually:
    /*
    <?xml version="1.0" encoding="utf-8"?>
    <CodeSnippets xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
      <CodeSnippet Format="1.0.0">
        <Header>
          <Title>propn</Title>
          <Shortcut>propn</Shortcut>
          <Description>Property with NotifyPropertyChanged</Description>
        </Header>
        <Snippet>
          <Code Language="csharp">
            <![CDATA[private $type$ _$property$;
    public $type$ $property$
    {
        get { return _$property$; }
        set 
        { 
            _$property$ = value;
            OnPropertyChanged(nameof($property$));
        }
    }]]>
          </Code>
          <Declarations>
            <Literal>
              <ID>type</ID>
              <Default>int</Default>
            </Literal>
            <Literal>
              <ID>property</ID>
              <Default>MyProperty</Default>
            </Literal>
          </Declarations>
        </Snippet>
      </CodeSnippet>
    </CodeSnippets>
    */

    // TASK: Create and use custom snippets for common patterns in your code
}
