// See https://aka.ms/new-console-template for more information
using FactoryMethodDesignPattern;

Console.WriteLine("Hello, World!");

Dialog windowsDialog = new WindowsDialog();
windowsDialog.Render(); // "Rendering Windows Button."

Dialog macDialog = new MacDialog();
macDialog.Render(); // "Rendering Mac Button."

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


DatabaseFactory sqlFactory = new SqlConnectionFactory();
IDatabaseConnection sqlConnection = sqlFactory.CreateConnection();
sqlConnection.Connect(); // "Connected to SQL Database."

DatabaseFactory mySqlFactory = new MySqlConnectionFactory();
IDatabaseConnection mySqlConnection = mySqlFactory.CreateConnection();
mySqlConnection.Connect(); // "Connected to MySQL Database."

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

ReportFactory pdfFactory = new PdfReportFactory();
IReport pdfReport = pdfFactory.CreateReport();
pdfReport.Generate(); // "Generating PDF Report."

ReportFactory excelFactory = new ExcelReportFactory();
IReport excelReport = excelFactory.CreateReport();
excelReport.Generate(); // "Generating Excel Report."


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

CharacterFactory warriorFactory = new WarriorFactory();
IGameCharacter warrior = warriorFactory.CreateCharacter();
warrior.Attack(); // "Warrior attacks with sword."

CharacterFactory mageFactory = new MageFactory();
IGameCharacter mage = mageFactory.CreateCharacter();
mage.Attack(); // "Mage attacks with magic."

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

NotificationFactory emailFactory = new EmailNotificationFactory();
INotification emailNotification = emailFactory.CreateNotification();
emailNotification.Notify("Hello via Email!"); // "Sending Email: Hello via Email!"

NotificationFactory smsFactory = new SmsNotificationFactory();
INotification smsNotification = smsFactory.CreateNotification();
smsNotification.Notify("Hello via SMS!"); // "Sending SMS: Hello via SMS!"
