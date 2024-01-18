internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Value of y = root(3^2)*x is:");
        for (int x = 0; x<=10; x++)
        {
            double y = Math.Sqrt(Math.Pow(3, 2)) * x;
            
            Console.WriteLine($"{y}, x= {x}");
        }
        
    }
}