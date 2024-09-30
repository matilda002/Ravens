using System.Runtime.CompilerServices;
using Npgsql;
public class Finance
{
    public void GetUtgifter()
    {
        using (var connection = new DatabaseConnection().GetConnection())
        {
            connection.Open();
            string selectQuery = "Select sum(Utgifter) from Finans";

            using (var cmd = new NpgsqlCommand(selectQuery, connection))
            {
                var result = cmd.ExecuteScalar();
                Console.WriteLine("Utgifter: {result}");
            }

        }
    }
}