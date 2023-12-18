namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();

            myCar.Make = "Jeep";
            myCar.Model = "Grand Cherokee";
            myCar.Year = 2021;

        Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}.");

        }

    }
}
