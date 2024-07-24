// See https://aka.ms/new-console-template for more information
using AbstractFactoryDesignPattern;

Console.WriteLine("Hello, World!");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

IGUIFactory factory;

// İşletim sistemi Windows ise
factory = new WinFactory();
Application app = new Application(factory);
app.Paint(); // "Rendering a button in a Windows style." ve "Rendering a checkbox in a Windows style." çıktısı

// İşletim sistemi MacOS ise
factory = new MacFactory();
app = new Application(factory);
app.Paint(); // "Rendering a button in a MacOS style." ve "Rendering a checkbox in a MacOS style." çıktısı


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


IDbFactory factory1;

// SQL Server kullanıyorsak
factory1 = new SqlFactory();
DatabaseClient client = new DatabaseClient(factory1);
client.Run(); // "Connecting to SQL Server." ve "Executing SQL Command." çıktısı

// MySQL kullanıyorsak
factory1 = new MySqlFactory();
client = new DatabaseClient(factory1);
client.Run(); // "Connecting to MySQL." ve "Executing MySQL Command." çıktısı

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

INotificationFactory factory2;

// Email bildirimi gönderiyorsak
factory2 = new EmailNotificationFactory();
NotificationService service = new NotificationService(factory2);
service.SendNotification("Hello via Email!"); // "Email Template: Sending Email: Hello via Email!" çıktısı

// SMS bildirimi gönderiyorsak
factory2 = new SmsNotificationFactory();
service = new NotificationService(factory2);
service.SendNotification("Hello via SMS!"); // "SMS Template: Sending SMS: Hello via SMS!" çıktısı

