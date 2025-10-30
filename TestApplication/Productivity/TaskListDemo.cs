// Exercise 15: Task List
// Practice: View > Task List, custom tokens

namespace TestApplication.Productivity
{
    // This class demonstrates Task List functionality
    // TASKS:
    // 1. Add TODO, HACK, UNDONE comments
    // 2. View > Task List to see all tasks
    // 3. Add custom tokens in Options > Environment > Task List
    // 4. Double-click tasks to navigate to code
    
    public class TaskListDemo
    {
        // TODO: Implement this method
        public void MethodToImplement()
        {
            // This method needs implementation
        }

        // TODO: Add error handling
        // TODO: Add logging
        // TODO: Add validation
        public void MethodNeedsWork(string input)
        {
            Console.WriteLine(input);
        }

        // HACK: This is a temporary workaround
        public void TemporaryFix()
        {
            // This should be refactored later
            System.Threading.Thread.Sleep(1000);
        }

        // UNDONE: Feature not complete
        public void IncompleteFeature()
        {
            // Partial implementation
        }

        // TODO: Refactor this method - it's too long
        public void LongMethod()
        {
            var step1 = "Step 1";
            var step2 = "Step 2";
            var step3 = "Step 3";
            // ... many more lines
        }

        // TODO: Add unit tests for this method
        public int Calculate(int a, int b)
        {
            return a + b;
        }

        // TODO: Optimize performance - this is slow
        public void SlowMethod()
        {
            for (int i = 0; i < 1000000; i++)
            {
                // Inefficient code
            }
        }

        // HACK: Remove this when API is fixed
        public void ApiWorkaround()
        {
            // Temporary solution
        }

        // TODO: Replace with dependency injection
        private void CreateDependency()
        {
            // Hard-coded dependency
        }

        // UNDONE: Async implementation pending
        public void SyncMethod()
        {
            // Should be async
        }

        // TODO: Add XML documentation
        public string FormatData(string input)
        {
            return input.ToUpper();
        }

        // Multiple TODOs in one method
        public void ComplexMethod()
        {
            // TODO: Add input validation
            
            // TODO: Add error handling
            
            // TODO: Add logging
            
            // TODO: Add caching
        }

        // TODO: Priority HIGH - Fix critical bug
        public void CriticalMethod()
        {
            // Important fix needed
        }

        // TODO: Priority LOW - Nice to have feature
        public void OptionalFeature()
        {
            // Can be implemented later
        }

        // HACK: Workaround for third-party library bug
        public void ThirdPartyWorkaround()
        {
            // Remove when library is updated
        }

        // UNDONE: Waiting for requirements clarification
        public void UnclearRequirements()
        {
            // Needs product owner input
        }

        // TODO: @john - Review this implementation
        public void NeedsReview()
        {
            // Assigned to specific person
        }

        // TODO: [FEATURE-123] - Implement feature from ticket
        public void FeatureFromTicket()
        {
            // Linked to issue tracker
        }

        // TODO: Deadline: 2024-12-31
        public void DeadlineTask()
        {
            // Time-sensitive task
        }
    }

    // CUSTOM TOKENS
    // To add custom tokens:
    // 1. Tools > Options
    // 2. Environment > Task List
    // 3. Add custom tokens like: FIXME, BUG, NOTE, REVIEW
    
    public class CustomTokensDemo
    {
        // FIXME: This calculation is incorrect
        public int BrokenCalculation()
        {
            return 1 + 1; // Should be different logic
        }

        // BUG: Null reference exception possible here
        public void PotentialBug(string input)
        {
            Console.WriteLine(input.Length);
        }

        // NOTE: This is important information
        public void ImportantNote()
        {
            // Remember to update this when changing X
        }

        // REVIEW: Code review needed
        public void NeedsCodeReview()
        {
            // Complex logic that needs peer review
        }

        // OPTIMIZE: Performance bottleneck
        public void PerformanceIssue()
        {
            // Slow operation
        }


        // SECURITY: Potential security vulnerability
        public void SecurityConcern(string userInput)
        {
            // Needs input sanitization
        }

        // REFACTOR: This code is messy
        public void MessyCode()
        {
            // Needs cleanup
        }

        // TEST: Add test coverage
        public void UntestedCode()
        {
            // No unit tests yet
        }
    }

    // ORGANIZING TASKS BY CATEGORY
    public class OrganizedTasks
    {
        // TODO: [DATA] Add database connection
        public void DatabaseTask()
        {
        }

        // TODO: [UI] Update user interface
        public void UiTask()
        {
        }

        // TODO: [API] Implement REST endpoint
        public void ApiTask()
        {
        }

        // TODO: [PERF] Improve query performance
        public void PerformanceTask()
        {
        }

        // TODO: [DOC] Add documentation
        public void DocumentationTask()
        {
        }
    }

    // TASK PRIORITIES
    public class TaskPriorities
    {
        // TODO: !!! CRITICAL - Fix production bug
        public void CriticalBug()
        {
        }

        // TODO: !! HIGH - Important feature
        public void HighPriority()
        {
        }

        // TODO: ! MEDIUM - Regular task
        public void MediumPriority()
        {
        }

        // TODO: LOW - Nice to have
        public void LowPriority()
        {
        }
    }

    // TASK WORKFLOW
    public class TaskWorkflow
    {
        // TODO: Start - Not started yet
        public void NotStarted()
        {
        }

        // TODO: In Progress - Currently working on this
        public void InProgress()
        {
            // Partial implementation
        }

        // TODO: Blocked - Waiting for dependency
        public void Blocked()
        {
            // Cannot proceed until X is done
        }

        // TODO: Review - Ready for code review
        public void ReadyForReview()
        {
            // Implementation complete
        }

        // DONE: Completed task (won't show in task list by default)
        public void CompletedTask()
        {
            // Fully implemented
        }
    }

    // TIPS FOR USING TASK LIST:
    // 1. View > Task List (Ctrl + \, T)
    // 2. Filter by token type (TODO, HACK, etc.)
    // 3. Sort by priority, file, or description
    // 4. Double-click to navigate to code
    // 5. Use consistent format for better organization
    // 6. Add custom tokens for your workflow
    // 7. Include assignee, deadline, or ticket number
    // 8. Review task list regularly
    // 9. Clean up completed tasks
    // 10. Use task list for code review checklist

    // PRACTICE AREA
    public class TaskListPractice
    {
        // Add various TODO comments here
        
        public void Exercise1()
        {
            // Add TODO: Implement validation
        }

        public void Exercise2()
        {
            // Add HACK: Temporary fix
        }

        public void Exercise3()
        {
            // Add TODO with priority and assignee
        }

        public void Exercise4()
        {
            // Add TODO with category and deadline
        }

        public void Exercise5()
        {
            // Add custom token (after configuring in Options)
        }
    }
}
