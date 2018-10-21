using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int luckyTickets = 0;
            int unluckyTickets = 0;

            
            for (int i = 0; i < 1000000; i++)
            {
                if ((i / 100000 + i % 100000 / 10000 + i % 100000 % 10000 / 1000) == (i % 100000 % 10000 % 1000 / 100 + i % 100000 % 10000 % 1000 % 100 / 10 + i % 10))
                {
                    Console.WriteLine(i);
                    luckyTickets++;
                }
                else
                {
                    unluckyTickets++;
                }
            }

            Console.WriteLine("The number of lucky tickets is: " + luckyTickets);
            Console.WriteLine("The number of unlucky tickets is: " + unluckyTickets);
            Console.WriteLine($"Total tickets: {luckyTickets + unluckyTickets}");
        }
    }
}
