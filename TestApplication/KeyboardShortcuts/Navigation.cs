// Exercise 3: Navigation
// Practice: F12, Ctrl + Click, Ctrl + R + Ctrl + R

namespace TestApplication.KeyboardShortcuts
{
    // This class demonstrates navigation shortcuts
    // TASKS:
    // 1. Use F12 to go to definition
    // 2. Use Ctrl + Click as alternative
    // 3. Use Ctrl + R, Ctrl + R to rename symbols
    // 4. Use Shift + F12 to find all references
    
    public class NavigationDemo
    {
        private readonly IDataService _dataService;
        private readonly ILogger _logger;

        public NavigationDemo(IDataService dataService, ILogger logger)
        {
            _dataService = dataService;
            _logger = logger;
        }

        // TASK: Place cursor on GetUserData and press F12 to see definition
        public void ProcessUser(int userId)
        {
            var userData = _dataService.GetUserData(userId);
            _logger.Log($"Processing user: {userData.Name}");
            
            // TASK: Ctrl + Click on ValidateUser to jump to definition
            if (ValidateUser(userData))
            {
                SaveUser(userData);
            }
        }

        // TASK: Place cursor on 'ValidateUser' method name
        // Press Ctrl + R, Ctrl + R to rename it to 'IsUserValid'
        // Notice how all references update automatically
        private bool ValidateUser(UserData user)
        {
            return user != null && !string.IsNullOrEmpty(user.Name);
        }

        // TASK: Place cursor on SaveUser and press Shift + F12 
        // to find all references to this method
        private void SaveUser(UserData user)
        {
            _dataService.SaveUser(user);
            _logger.Log($"User saved: {user.Name}");
        }

        // TASK: Rename this variable using Ctrl + R, Ctrl + R
        private const string DEFAULT_MESSAGE = "Hello World";

        public void UseConstant()
        {
            Console.WriteLine(DEFAULT_MESSAGE);
            _logger.Log(DEFAULT_MESSAGE);
        }
    }

    // Supporting classes for navigation practice
    public interface IDataService
    {
        UserData GetUserData(int userId);
        void SaveUser(UserData user);
        List<UserData> GetAllUsers();
    }

    public interface ILogger
    {
        void Log(string message);
        void LogError(string message);
    }

    public class UserData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    // TASK: Implement this class
    // Use F12 on IDataService to see what methods need implementation
    public class DataService : IDataService
    {
        private List<UserData> _users = new List<UserData>();

        public UserData GetUserData(int userId)
        {
            return _users.FirstOrDefault(u => u.Id == userId);
        }

        public void SaveUser(UserData user)
        {
            _users.Add(user);
        }

        public List<UserData> GetAllUsers()
        {
            return _users;
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[INFO] {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"[ERROR] {message}");
        }
    }

    // TASK: Practice navigation workflow
    // 1. Start at Main method
    // 2. F12 on NavigationDemo to see class
    // 3. F12 on ProcessUser to see method
    // 4. Ctrl + Click on _dataService to see interface
    // 5. Find implementation using Ctrl + F12
    public class NavigationTestRunner
    {
        public static void Run()
        {
            var dataService = new DataService();
            var logger = new ConsoleLogger();
            var demo = new NavigationDemo(dataService, logger);

            demo.ProcessUser(1);
        }
    }
}
