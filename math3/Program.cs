// See https://aka.ms/new-console-template for more information
class Program
{


    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Ceilin: " + Math.Ceiling(a));

        Console.WriteLine("Floor  " + Math.Floor(a));
        Console.WriteLine("Truncate:  " + Math.Truncate(a));
        Console.ReadKey();
    }
}
