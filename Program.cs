namespace Ravens;

class Program
{
    static void Main(string[] args)
    {
        var financeMethods = new FinanceMethods();
        
        Console.WriteLine("\n");
        financeMethods.GetUtgifter();

        Console.WriteLine("\n");
        var utgifter = financeMethods.GetAllUtgifter();

        Console.WriteLine($"{"Titel",-25}{"Kund ID",-12}{"Utgifter",-15}{"Datum",-15}");
        Console.WriteLine(new string('-', 70));

        foreach (var utgift in utgifter)
        {
            Console.WriteLine($"{utgift.Title,-25}{utgift.CustomerId,-12}" +
                              $"{utgift.Expenditure,-15}{utgift.Date.ToShortDateString(),-15}");
        }
    }
}
