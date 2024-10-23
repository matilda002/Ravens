namespace Ravens;

using Npgsql;

public class FinanceRevenue
{
    private object? ConnectionExecuteScalar(string query)
    {
        try
        {
            using var connection = new DatabaseConnection().GetConnection();
            connection.Open();

            using var cmd = new NpgsqlCommand(query, connection);
            return cmd.ExecuteScalar();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }

    public void GetRevenue()
    {
        const string qSelectRevenue = "select sum(revenue) from finance";

        var totalRevenue = ConnectionExecuteScalar(qSelectRevenue);

        Console.WriteLine($"Totala summan intäkter: {totalRevenue} kr");
    }

    public void GetCurrentDateRevenue()
    {
        const string qSelectCurrenDateRevenue = "select sum(revenue) from finance where datetime = current_date";

        var currentDateRevenue = ConnectionExecuteScalar(qSelectCurrenDateRevenue);

        Console.WriteLine($"Dagens intäkter: {currentDateRevenue} kr");
    }
}