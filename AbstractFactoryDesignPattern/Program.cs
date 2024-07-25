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


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();



IGameFactory factory3;

// Oyun platformuna göre factory seçimi
factory3 = new PcGameFactory();
Game game = new Game(factory3);
game.Play(); // "PC character attacks with a gun." ve "PC weapon: using a laser."

factory3 = new MobileGameFactory();
game = new Game(factory3);
game.Play(); // "Mobile character attacks with a swipe." ve "Mobile weapon: using a touch attack."


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


IReportFactory factory4;

// Rapor formatına göre factory seçimi
factory4 = new PdfReportFactory();
ReportGenerator generator = new ReportGenerator(factory4);
generator.GenerateReport(); // "Generating PDF report." ve "Drawing PDF chart."

factory4 = new ExcelReportFactory();
generator = new ReportGenerator(factory4);
generator.GenerateReport(); // "Generating Excel report." ve "Drawing Excel chart."


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


IConfigFactory factory5;

// Ortam türüne göre factory seçimi
factory5 = new DevConfigFactory();
ApplicationConfigurator configurator = new ApplicationConfigurator(factory5);
configurator.Configure(); // "Configuring development database." ve "Setting up development logging."

factory5 = new ProdConfigFactory();
configurator = new ApplicationConfigurator(factory5);
configurator.Configure(); // "Configuring production database." ve "Setting up production logging."
