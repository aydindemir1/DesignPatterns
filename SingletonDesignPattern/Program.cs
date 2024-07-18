// See https://aka.ms/new-console-template for more information

using SingletonDesignPattern;

Console.WriteLine();
Console.WriteLine();

Singleton singleton = Singleton.Instance;
singleton.DoSomething();

Console.WriteLine();
Console.WriteLine();

Logger logger = Logger.Instance;
logger.Log("This is a log message.");

Console.WriteLine();
Console.WriteLine();

DatabaseConnection dbConnection = DatabaseConnection.Instance;
dbConnection.OpenConnection();
// Perform database operations
dbConnection.CloseConnection();

Console.WriteLine();
Console.WriteLine();

var apiUrl = ConfigurationManager.Instance.GetSetting("ApiUrl");
Console.WriteLine(apiUrl);

Console.WriteLine();
Console.WriteLine();

CacheManager.Instance.AddItem("username", "john_doe");
var username = CacheManager.Instance.GetItem("username");
Console.WriteLine(username);

Console.WriteLine();
Console.WriteLine();

ServiceManager.Instance.RegisterService("UserService", "http://localhost:5000/api/users");
var userServiceUrl = ServiceManager.Instance.GetServiceUrl("UserService");
Console.WriteLine(userServiceUrl);

Console.WriteLine();
Console.WriteLine();

GameManager.Instance.AddScore(10);
Console.WriteLine("Current Score: " + GameManager.Instance.Score);