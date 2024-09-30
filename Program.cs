namespace Ravens;

class Program
{
    static void Main(string[] args)
    {
        var financeMethods = new FinanceMethods();

        // Test GetUtgifter
        Console.WriteLine("\nTesting GetUtgifter method:");
        financeMethods.GetUtgifter();

        // Test GetAllUtgifter
        Console.WriteLine("\nTesting GetAllUtgifter method:");
        var utgifter = financeMethods.GetAllUtgifter();
        foreach (var utgift in utgifter)
        {
            Console.WriteLine($"Titel: {utgift.Title}, Kund ID: {utgift.CustomerId}, " +
                              $"Utgifter: {utgift.Expenditure} kr, Datum: {utgift.Date.ToShortDateString()}");
        }
    }
}