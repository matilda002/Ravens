namespace Ravens;
using Npgsql;

public class FinanceRevenue {
    
    public void GetRevenue(){

        using var connection = new DatabaseConnection().GetConnection();
        connection.Open();

        const string qSelectRevenue = "select sum(revenue) from finance";
        
        using var cmd = new NpgsqlCommand(qSelectRevenue, connection);
        var totalRevenue = cmd.ExecuteScalar();
        
        Console.WriteLine($"Totala summan intäkter: {totalRevenue} kr");
    }

    public void GetTodaysRevenue(){
        
        using var connection = new DatabaseConnection().GetConnection();
        connection.Open();

        const string qSelectTodaysRevenue = "select sum(revenue) from finance where datetime = current_date";
        
        using var cmd = new NpgsqlCommand(qSelectTodaysRevenue, connection);
        var TodaysRevenue = cmd.ExecuteScalar();
        
        Console.WriteLine($"Dagens intäkter: {TodaysRevenue} kr");
    }
}