namespace Ravens;

public class Finance
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public int CustomerId { get; set; }
    public int ServiceId { get; set; }
    public double Revenue { get; set; }
    public double Expenditure { get; set; }
    public DateTime Date { get; set; }
}