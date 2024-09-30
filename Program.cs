class Program
{
    static void Main(string[] args)
    {
        var financeMethods = new FinanceMethods();

        // Test GetUtgifter
        Console.WriteLine("Testing GetUtgifter method:");
        financeMethods.GetUtgifter();

        // Test GetAllUtgifter
        Console.WriteLine("\nTesting GetAllUtgifter method:");
        var utgifter = financeMethods.GetAllUtgifter();
        foreach (var utgift in utgifter)
        {
            Console.WriteLine($"ID: {utgift.Id}, Title: {utgift.Title}, " +
                              $"Customer ID: {utgift.CustomerId}, Service ID: {utgift.ServiceId}, " +
                              $"Revenue: {utgift.Revenue} kr, Expenditure: {utgift.Expenditure} kr, " +
                              $"Datetime: {utgift.Datetime}");
        }
    }
}