// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
//Console.ReadLine();

//md => markdown
//Ctel.+

string connectionString = "Data Source=.;Initial Catalog=WNYKDotNetCore;User ID=sa;Password=sasa@123;";
Console.WriteLine("Connection string:" + connectionString);
SqlConnection connection = new SqlConnection(connectionString);

Console.WriteLine("Connection opening...");
connection.Open();
Console.WriteLine("Connection opened..");

string qry = @"SELECT [BlogId]
      ,[BlogTitle]
      ,[BlogAuthor]
      ,[BlogContent]
      ,[DeleteFlag]
  FROM [dbo].[Tbl_Blog] where DeleteFlag=0";
SqlCommand cmd = new SqlCommand(qry, connection);//Create Cpmmand=>fill Query
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);//Accept Query
//DataTable dt = new DataTable(); //Create Table
//adapter.Fill(dt); //same execute function

SqlDataReader reader = cmd.ExecuteReader();
while (reader.Read())
{
    Console.WriteLine(reader["BlogId"]);
    Console.WriteLine(reader["BlogTitle"]);
    Console.WriteLine(reader["BlogAuthor"]);
    Console.WriteLine(reader["BlogContent"]);
}

Console.WriteLine("Connection closing..");
connection.Close();
Console.WriteLine("Connection closed..");

//DataSet
//DataRow => dr
//DataColumn
//DataTable
//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["Blogld"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);
//}

Console.ReadKey();