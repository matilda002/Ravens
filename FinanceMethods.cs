using System.Runtime.CompilerServices;
using Npgsql;
namespace Ravens;
public class FinanceMethods
{
    public void GetUtgifter()
    {
        using var connection = new DatabaseConnection().GetConnection();
        connection.Open();
        string selectQuery = "Select sum(expenditure) from finance";

        using var cmd = new NpgsqlCommand(selectQuery, connection);
        var result = cmd.ExecuteScalar();
        Console.WriteLine($"Utgifter: {result} kr");
    }

    public List<Finance> GetAllUtgifter()
    {
        var utgifterList = new List<Finance>();

        using (var connection = new DatabaseConnection().GetConnection())
        {
            connection.Open();
            string query = "SELECT * FROM finance";

            using (var cmd = new NpgsqlCommand(query, connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var finans = new Finance
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        CustomerId = reader.GetInt32(2),
                        ServiceId = reader.GetInt32(3),
                        Revenue = reader.GetDouble(4),
                        Expenditure = reader.GetDouble(5),
                        Date = reader.GetDateTime(6)
                    };
                    utgifterList.Add(finans);
                }
            }
        }

        return utgifterList;
    }
}