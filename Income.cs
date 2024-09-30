namespace Ravens;
using Npgsql;

public class FinanceIncome {
    
    public void GetRevenue(){

        using var connection = new DatabaseConnection().GetConnection();
        connection.Open();

        const string qSelectRevenue = "select sum(revenue) from finance";
        
        using var cmd = new NpgsqlCommand(qSelectRevenue, connection);
        var totalRevenue = cmd.ExecuteScalar();
        
        Console.WriteLine($"Totala summan intäkter: {totalRevenue} kr");
    }


}