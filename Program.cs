public class program
{
    public static async Task Main(string[] args)
    {
        //PrinterTwo();
        PrinterTwoAsync(); //  3 Sec Wait time
        PrinterOne();
        PrinterThree();
        Console.WriteLine("\nMain program");
        Console.ReadKey();
    }
    public static void PrinterOne()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("printer one");
            Task.Delay(1000).Wait();
        }
    }

    public static void PrinterTwo()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("printer two");
            Task.Delay(1000).Wait();
        }
    }

    public static void PrinterThree()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("printer Three");
            Task.Delay(1000).Wait();
        }
    }

    public static async Task PrinterTwoAsync()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Async Printer Two");
                Task.Delay(3000).Wait();
            }
        });
    }
}