using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Do you want to see a full deck of cards? (yes or no)");
            string answer = Console.ReadLine();

            while (answer != "yes")
            {
                Console.WriteLine("Do you want to see a full deck of cards? (yes or no)");
                answer = Console.ReadLine();
            }

            Console.WriteLine($"A ♥, A ♦, A ♣, A ♠");
            Console.WriteLine($"2 ♥, 2 ♦, 2 ♣, 2 ♠");
            Console.WriteLine($"3 ♥, 3 ♦, 3 ♣, 3 ♠");
            Console.WriteLine($"4 ♥, 4 ♦, 4 ♣, 4 ♠");
            Console.WriteLine($"5 ♥, 5 ♦, 5 ♣, 5 ♠");
            Console.WriteLine($"6 ♥, 6 ♦, 6 ♣, 6 ♠");
            Console.WriteLine($"7 ♥, 7 ♦, 7 ♣, 7 ♠");
            Console.WriteLine($"8 ♥, 8 ♦, 8 ♣, 8 ♠");
            Console.WriteLine($"9 ♥, 9 ♦, 9 ♣, 9 ♠");
            Console.WriteLine($"10 ♥, 10 ♦, 10 ♣, 10 ♠");
            Console.WriteLine($"J ♥, J ♦, J ♣, J ♠");
            Console.WriteLine($"Q ♥, Q ♦, Q ♣, Q ♠");
            Console.WriteLine($"K ♥, K ♦, K ♣, K ♠");
        }

    }
}
