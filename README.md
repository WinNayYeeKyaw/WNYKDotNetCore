# WNYKDotNetCore

***C# Basic***
C# is used for:
Mobile applications
Desktop applications
Web applications
Web services
Web sites
Games
VR
Database applications
And much, much more!

***C#ariable***
int age = 30;
double price = 19.99;
char grade = 'A';
string name = "John";
bool isActive = true;

7-September-2024
C#=>language/ .Net=> frame

***ConsoleApp***
ASP.NET core Web API
ASP.NET Core Web MVC
Blazor Web Assembly
Blazor Web Server

***Teaching logic***
UI=>Business Logic=>Data Access=>Database

***Create Table in SQL***
-need to main key(primary)
-insert=>Indentity specification double click=>IS identity=>when insert increase 1+
-nvarchar can use Other Launguage
-varchar only use mother launguage
-nvarchar max size=>4,000
-

***SqlConnection Key => Ctrl.+***
***Database***
CRUD=> Create, Read, Update, Delete

***SQL Database & C# Connection open/close function***
string connectionString = "Data Source=.;Initial Catalog=WNYKDotNetCore;User ID=sa;Password=sasa@123;";
Console.WriteLine("Connection string:" + connectionString);
SqlConnection connection = new SqlConnection(connectionString);
Console.WriteLine("Connection opening...");
connection.Open();
Console.WriteLine("Connection opened..");
Console.WriteLine("Connection closing..");
connection.Close();
Console.WriteLine("Connection closed..");
       





