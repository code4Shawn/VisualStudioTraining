# Visual Studio 2022 Productivity Test Scenarios

This project contains hands-on exercises to practice all the tips and tricks from the VS productivity guide.

## 📋 Table of Contents
1. [Keyboard Shortcuts](#keyboard-shortcuts)
2. [Code Navigation & IntelliSense](#code-navigation--intellisense)
3. [Debugging Essentials](#debugging-essentials)
4. [Extensions & Tools](#extensions--tools)
5. [Productivity Hacks](#productivity-hacks)
6. [Best Practices](#best-practices)

---

## 🎯 Keyboard Shortcuts

### Exercise 1: Build and Run
**File:** `KeyboardShortcuts/BuildAndRun.cs`

1. **Ctrl + Shift + B** - Build the solution and observe errors
2. **Ctrl + \, E** - Open error list and navigate to errors
3. **F5** - Start debugging
4. **Ctrl + F5** - Run without debugging

### Exercise 2: Quick Actions
**File:** `KeyboardShortcuts/QuickActions.cs`

1. **Ctrl + .** - Generate missing methods, add using statements
2. **Alt + Enter** - Open lightbulb menu for quick fixes
3. **Ctrl + K, Ctrl + D** - Format the entire document

### Exercise 3: Navigation
**File:** `KeyboardShortcuts/Navigation.cs`

1. **F12** - Go to definition
2. **Ctrl + Click** - Alternative go to definition
3. **Ctrl + R, Ctrl + R** - Rename symbol across all references

### Exercise 4: Editing
**File:** `KeyboardShortcuts/EditingTricks.cs`

1. **Ctrl + Shift + L** - Delete entire line
2. **Ctrl + D** - Duplicate line
3. **Ctrl + Shift + V** - Cycle through clipboard history
4. **Ctrl + Shift + F** - Find in files with regex

---

## 🧭 Code Navigation & IntelliSense

### Exercise 5: Advanced Navigation
**Files:** `Navigation/Calculator.cs`, `Navigation/MathOperations.cs`, `Navigation/StringHelpers.cs`

1. **Ctrl + T** - Go to All (try "T:Calculator", "M:Add")
2. **Ctrl + Shift + T** - Reopen closed tab
3. **Ctrl + Tab** - Cycle through open documents
4. **Alt + F12** - Peek Definition without leaving file
5. **Shift + F12** - Find All References
6. **Ctrl + K, Ctrl + T** - Call Hierarchy

### Exercise 6: IntelliSense Practice
**File:** `Navigation/IntelliSenseDemo.cs`

1. Type code and observe IntelliSense suggestions
2. Use breadcrumb navigation at the top
3. Enable Code Lens (Options > Text Editor > All Languages > Code Lens)
4. Hover over methods to see reference counts

---

## 🐛 Debugging Essentials

### Exercise 7: Basic Debugging
**File:** `Debugging/BasicDebugging.cs`

1. Set regular breakpoints (F9)
2. **F10** - Step Over
3. **F11** - Step Into
4. **Shift + F11** - Step Out
5. Hover over variables to see DataTips
6. Pin DataTips for persistence

### Exercise 8: Advanced Breakpoints
**File:** `Debugging/ConditionalBreakpoints.cs`

1. Right-click breakpoint → Conditions (e.g., `i > 5`)
2. Set hit count conditions
3. Add expressions to Watch window
4. Use Exception Settings (Ctrl + Alt + E)

### Exercise 9: Interactive Debugging
**File:** `Debugging/InteractiveDebug.cs`

1. Use **Immediate Window** (Ctrl + Alt + I) to evaluate expressions
2. Try `? variableName.ToString()`
3. Modify variables during debugging
4. Test **Edit and Continue** - change code while debugging

---

## 🔧 Extensions & Tools

### Exercise 10: NuGet Packages
**File:** `Extensions/NuGetDemo.cs`

1. Open Package Manager Console
2. Install packages: `Install-Package Serilog`
3. Use NuGet GUI (Tools > NuGet Package Manager)

### Exercise 11: Git Integration
**Files:** Various

1. Open Git Changes window (View > Git Changes)
2. Stage changes
3. Create commits
4. View Git history
5. Create and switch branches

---

## ⚡ Productivity Hacks

### Exercise 12: Code Snippets
**File:** `Productivity/SnippetsDemo.cs`

1. Type `ctor` + Tab - Generate constructor
2. Type `prop` + Tab - Generate property
3. Type `propfull` + Tab - Generate full property
4. Type `for` + Tab - Generate for loop
5. Type `try` + Tab - Generate try-catch
6. Create custom snippet (Tools > Code Snippets Manager)

### Exercise 13: Multi-Cursor Editing
**File:** `Productivity/MultiCursorDemo.cs`

1. **Ctrl + Alt + Click** - Place multiple cursors
2. Edit multiple lines simultaneously
3. **Alt + Shift + .** - Select next occurrence
4. **Alt + Shift + ;** - Select all occurrences

### Exercise 14: Surround With
**File:** `Productivity/SurroundWithDemo.cs`

1. Select code
2. **Ctrl + K, Ctrl + S** - Surround with if, try-catch, region, etc.

### Exercise 15: Task List
**File:** `Productivity/TaskListDemo.cs`

1. Add `// TODO: Fix this` comments
2. View in **View > Task List**
3. Add custom tokens (Options > Environment > Task List)

### Exercise 16: Split Windows & Bookmarks
**Files:** Various

1. Drag tab to side for split view
2. **Ctrl + K, Ctrl + K** - Toggle bookmark
3. **Ctrl + K, Ctrl + N** - Next bookmark
4. **Ctrl + K, Ctrl + P** - Previous bookmark

---

## 🎨 Best Practices

### Exercise 17: Code Analysis
**File:** `BestPractices/CodeAnalysisDemo.cs`

1. Observe Roslyn analyzer warnings
2. Configure `.editorconfig` for rules
3. Use Quick Actions to fix issues

### Exercise 18: Live Unit Testing
**Files:** `BestPractices/Calculator.cs`, `BestPractices/CalculatorTests.cs`

1. Enable Live Unit Testing (Test > Live Unit Testing > Start)
2. See test results in real-time as you code
3. Observe green/red indicators in editor

### Exercise 19: Settings Customization
1. **Tools > Options > Environment > Fonts and Colors** - Change theme
2. **Tools > Import and Export Settings** - Backup settings
3. Enable **Lightweight Solution Load** for large projects
4. Sync settings via Microsoft account

---

## 🎓 Practice Workflow

### Recommended Order:
1. Start with **Keyboard Shortcuts** (Exercises 1-4) - Build muscle memory
2. Move to **Navigation** (Exercises 5-6) - Learn to move efficiently
3. Practice **Debugging** (Exercises 7-9) - Master troubleshooting
4. Explore **Productivity Hacks** (Exercises 12-16) - Speed up coding
5. Configure **Best Practices** (Exercises 17-19) - Optimize environment

### Tips:
- Practice each exercise 3-5 times until shortcuts become natural
- Use a test project to avoid disrupting production code
- Keep this guide open in a split window while practicing
- Time yourself before and after to measure improvement

---

## 📚 Additional Resources
- [Microsoft Learn - Visual Studio](https://learn.microsoft.com/visualstudio/)
- [VS Keyboard Shortcuts PDF](https://visualstudio.microsoft.com/keyboard-shortcuts.pdf)
- [Visual Studio Blog](https://devblogs.microsoft.com/visualstudio/)
- [Stack Overflow - Visual Studio Tag](https://stackoverflow.com/questions/tagged/visual-studio)

---

## 🏆 Challenge Goals
- [ ] Memorize 15+ keyboard shortcuts
- [ ] Navigate code without using mouse for 10 minutes
- [ ] Debug a complex issue using conditional breakpoints
- [ ] Create 3 custom code snippets
- [ ] Set up and use Live Unit Testing
- [ ] Reduce coding time by 30% (measure with time tracking)

**Happy Coding! 🚀**
