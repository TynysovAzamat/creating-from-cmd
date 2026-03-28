using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
public class Connection
{
    public void StrinngConection()
    {
        using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["LeessonDB"].ConnectionString))
        {
            sqlConnection.Open();
            Console.WriteLine("Finaly, its worked!");
            Console.WriteLine("Can i change it?");
            Console.ReadLine();
        }
    }
}
public static class Test
{
    public static void Main(string[] args)
    {
        var test = new Connection();
        test.StrinngConection();
    }
}


