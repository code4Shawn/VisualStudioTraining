# Live Unit Testing Guide

## ⚠️ Edition Requirement

**Live Unit Testing is ONLY available in Visual Studio Enterprise Edition**

- ✅ Visual Studio 2022 Enterprise
- ❌ Visual Studio 2022 Professional (NOT available)
- ❌ Visual Studio 2022 Community (NOT available)

If you don't have Enterprise, see [Alternatives](#alternatives) below.

---

## 🎯 What is Live Unit Testing?

Live Unit Testing automatically runs your unit tests in the background as you edit code and shows real-time results directly in the editor.

### Visual Indicators (Glyphs)

| Icon | Meaning |
|------|---------|
| ✅ Green checkmark | Line is covered by passing test(s) |
| ❌ Red X | Line is covered by failing test(s) |
| ➖ Blue dash | Line is NOT covered by any tests |
| ⚪ Gray circle | Code changed, tests need to re-run |
| 🔄 Spinning icon | Tests are currently running |

---

## 🚀 How to Enable (Enterprise Only)

### Method 1: Menu
1. **Test** menu
2. **Live Unit Testing**
3. **Start**

### Method 2: Keyboard Shortcut
- Press **Ctrl + Q**
- Type "Live Unit Testing"
- Select **"Test.LiveUnitTesting.Start"**

### Method 3: Test Explorer
1. Open **Test Explorer** (**Ctrl + E, T**)
2. Click **Live Unit Testing** button in toolbar
3. Select **Start**

---

## ⚙️ Configuration

**Test > Live Unit Testing > Options**

### Recommended Settings:

```
✅ Enable Live Unit Testing on solution open
✅ Automatically run tests after build
✅ Show coverage indicators in editor
⏱️ Test execution timeout: 30 seconds
📁 Include all test projects
💾 Persist data between sessions
```

### Performance Settings:

```
⚡ Run tests in parallel
🎯 Only run tests for changed code
📊 Limit number of concurrent test runs
💽 Use test result cache
```

---

## 🧪 Try It Yourself

### Step 1: Install xUnit (if not already installed)

Open **Package Manager Console** and run:
```powershell
Install-Package xunit
Install-Package xunit.runner.visualstudio
Install-Package Microsoft.NET.Test.Sdk
```

### Step 2: Open Test Files

1. Open `BestPractices/Calculator.cs`
2. Open `BestPractices/CalculatorTests.cs`

### Step 3: Start Live Unit Testing

1. **Test > Live Unit Testing > Start**
2. Wait for initial test run (watch status bar)
3. Look at `Calculator.cs` - you'll see green checkmarks!

### Step 4: Make Changes and Watch

1. In `Calculator.cs`, change the `Add` method:
   ```csharp
   public int Add(int a, int b)
   {
       return a + b + 1;  // Intentional bug!
   }
   ```
2. Save the file
3. Watch the checkmark turn to ❌ red X
4. Fix it back and watch it turn green ✅

### Step 5: Add New Code

1. Add a new method without a test:
   ```csharp
   public int Square(int x)
   {
       return x * x;  // Will show blue dash (no coverage)
   }
   ```
2. Notice the ➖ blue dash indicator
3. Add a test in `CalculatorTests.cs`:
   ```csharp
   [Fact]
   public void Square_Number_ReturnsSquare()
   {
       int result = _calculator.Square(5);
       Assert.Equal(25, result);
   }
   ```
4. Watch the blue dash turn to green checkmark ✅

---

## 🎨 Visual Indicators Explained

### Green Checkmark ✅
```csharp
public int Add(int a, int b)
{
    return a + b;  // ✅ Covered by passing test
}
```

### Red X ❌
```csharp
public int Add(int a, int b)
{
    return a + b + 1;  // ❌ Bug! Test fails
}
```

### Blue Dash ➖
```csharp
public int Modulo(int a, int b)
{
    return a % b;  // ➖ No test covers this method
}
```

### Gray Circle ⚪
```csharp
public int Add(int a, int b)
{
    return a + b;  // ⚪ Just edited, tests need to run
}
```

---

## 🎛️ Live Unit Testing Controls

### Start/Stop/Pause
- **Test > Live Unit Testing > Start** - Begin testing
- **Test > Live Unit Testing > Pause** - Temporarily stop
- **Test > Live Unit Testing > Stop** - Completely stop

### Keyboard Shortcuts (can be customized)
- **Ctrl + Q** → Type "Live Unit Testing"
- Or assign custom shortcuts in **Tools > Options > Keyboard**

### Context Menu
Right-click in editor:
- **Live Unit Testing > Include/Exclude**
- **Live Unit Testing > Run Tests**

---

## 📊 Test Explorer Integration

Live Unit Testing works with **Test Explorer**:

1. Open **Test Explorer** (**Ctrl + E, T**)
2. See all tests with real-time status
3. Click test to navigate to code
4. See which tests cover each line

---

## 💡 Best Practices

### 1. Start Small
- Enable for one project first
- Expand to full solution once comfortable

### 2. Exclude Large Projects
- Right-click project > **Live Unit Testing > Exclude**
- Focus on projects you're actively editing

### 3. Use Filters
- Test Explorer: Filter by status (passed/failed/not run)
- Focus on failing tests first

### 4. Performance Tips
- Pause when not needed (large refactoring)
- Use "Run on save" instead of continuous
- Exclude slow integration tests

### 5. Code Coverage Goals
- Aim for ✅ green on critical paths
- ➖ Blue dashes show gaps in coverage
- Add tests for uncovered code

---

## 🔧 Troubleshooting

### Live Unit Testing Menu Not Visible?
- **You need Visual Studio Enterprise**
- Community/Professional don't have this feature

### Tests Not Running?
1. Check Test Explorer for errors
2. Verify test framework is installed (xUnit, NUnit, MSTest)
3. Rebuild solution (**Ctrl + Shift + B**)
4. Restart Live Unit Testing

### Performance Issues?
1. Pause Live Unit Testing during large refactors
2. Exclude non-critical projects
3. Increase timeout in options
4. Close other resource-heavy applications

### Indicators Not Showing?
1. Check **Test > Live Unit Testing > Options**
2. Verify "Show coverage indicators" is enabled
3. Restart Visual Studio
4. Clear test cache: **Test > Live Unit Testing > Clean**

---

## 🆚 Alternatives (If You Don't Have Enterprise)

### 1. **NCrunch** (Paid Extension)
- Similar to Live Unit Testing
- Works with all VS editions
- More features than Live Unit Testing
- **$159-$289/year**

### 2. **dotCover** (JetBrains - Paid)
- Continuous testing mode
- Code coverage visualization
- Part of ReSharper Ultimate
- **$149/year**

### 3. **Fine Code Coverage** (Free Extension)
- Shows coverage after test runs
- Not real-time, but free
- Works with Community edition
- Install: **Extensions > Manage Extensions**

### 4. **Manual Testing with Test Explorer**
- **Ctrl + E, T** - Open Test Explorer
- **Ctrl + R, A** - Run all tests
- **Ctrl + R, T** - Run tests in context
- Free, built into all editions

### 5. **Continuous Testing with dotnet watch**
- Command line tool (free)
- Watches files and re-runs tests
- Terminal: `dotnet watch test`

---

## 📈 Workflow Example

### Typical Development Flow with Live Unit Testing:

1. **Start your day:**
   - Open solution
   - **Test > Live Unit Testing > Start**
   - Wait for initial test run

2. **Write new feature:**
   - Add new method
   - See ➖ blue dash (no coverage)
   - Write test
   - See ✅ green checkmark

3. **Fix a bug:**
   - Modify code
   - See ❌ red X if test fails
   - Fix until ✅ green

4. **Refactor:**
   - Make changes
   - Watch indicators stay green
   - Confidence that nothing broke

5. **End of day:**
   - All code shows ✅ green
   - Commit with confidence
   - **Test > Live Unit Testing > Stop**

---

## 🎓 Learning Resources

### Official Documentation
- [Microsoft: Live Unit Testing](https://learn.microsoft.com/visualstudio/test/live-unit-testing)
- [Getting Started Guide](https://learn.microsoft.com/visualstudio/test/live-unit-testing-start)

### Video Tutorials
- Search YouTube: "Visual Studio Live Unit Testing"
- Microsoft Channel has official tutorials

### Practice Files in This Project
- `BestPractices/Calculator.cs` - Sample class
- `BestPractices/CalculatorTests.cs` - Sample tests
- Try editing and watching indicators change!

---

## 📋 Quick Reference

| Action | Shortcut/Menu |
|--------|---------------|
| Start Live Unit Testing | Test > Live Unit Testing > Start |
| Pause | Test > Live Unit Testing > Pause |
| Stop | Test > Live Unit Testing > Stop |
| Options | Test > Live Unit Testing > Options |
| Open Test Explorer | Ctrl + E, T |
| Run All Tests | Ctrl + R, A |
| Run Tests in Context | Ctrl + R, T |
| Debug Tests | Ctrl + R, Ctrl + T |

---

## ✅ Summary

**Live Unit Testing (Enterprise only):**
- ✅ Real-time test results in editor
- ✅ Visual indicators (green/red/blue)
- ✅ Automatic test execution
- ✅ Immediate feedback on changes
- ✅ Better code coverage awareness

**If you don't have Enterprise:**
- Use Test Explorer with manual runs
- Try NCrunch or dotCover (paid)
- Use Fine Code Coverage (free)
- Use `dotnet watch test` (command line)

---

**Remember:** Even without Live Unit Testing, writing tests and running them frequently is what matters most! 🧪✨
