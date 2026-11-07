class Program
{
    static void Main()
    {
        Calculator c = new Calculator();
        Console.WriteLine("Hieu 2 so nguyen: "+ c.Tru(40,4));
        Console.WriteLine("Hieu 2 so thuc: "+ c.Tru(40.5,4.5));
        Console.WriteLine("Hieu 3 so thuc: "+ c.Tru(80,5,8));
    }
}