namespace Ravens;

class Program
{
    static void Main(string[] args)
    {
        var financeMethods = new FinanceMethods();

        Console.WriteLine("\nTesting GetUtgifter method:");
        financeMethods.GetUtgifter();

        Console.WriteLine("\nTesting GetAllUtgifter method:");
        var utgifter = financeMethods.GetAllUtgifter();

        Console.WriteLine($"{"Titel",-30}{"Kund ID",-10}{"Utgifter",-15}{"Datum",-15}");
        Console.WriteLine(new string('-', 70));

        foreach (var utgift in utgifter)
        {
            Console.WriteLine($"{utgift.Title,-30}{utgift.CustomerId,-10}" +
                              $"{utgift.Expenditure,-15}{utgift.Date.ToShortDateString(),-15}");
        }
    }
}
