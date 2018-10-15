using System;

namespace DecartCoordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter A1: ");
            double A1 = double.Parse(Console.ReadLine());
            Console.Write("Enter A2: ");
            double A2 = double.Parse(Console.ReadLine());
            Console.Write("Enter B1: ");
            double B1 = double.Parse(Console.ReadLine());
            Console.Write("Enter B2: ");
            double B2 = double.Parse(Console.ReadLine());

            
            Console.WriteLine("The points have the following coordinates:");
            Console.WriteLine($"Point A({A1},{A2})");
            Console.WriteLine($"Point B({B1},{B2})");
         

            
            double distanceBetweenTwoPoints = Math.Sqrt(Math.Pow((B1 - A1), 2) + Math.Pow((B2 - A1), 2));
            Console.WriteLine($"The distance between the two pints is {distanceBetweenTwoPoints}.");
        
        }
    }
}
