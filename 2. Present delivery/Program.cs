using System;
using System.Collections.Generic;
using System.Linq;

namespace Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> santasList = Console.ReadLine().Split('@').Select(int.Parse).ToList();

            int position = 0;
            int count = 0;

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Merry")
                {
                    break;
                }
                if (command[0] == "Jump")
                {
                    int jump = int.Parse(command[1]);

                    position = (position + jump) % santasList.Count;

                    if (santasList[position] == 0)
                    {
                        Console.WriteLine($"House {position} will have a Merry Christmas.");
                    }
                    else
                    {
                        santasList[position] -= 2;
                    }
                }
            }
            Console.WriteLine($"Santa's last position was {position}.");

            foreach (var item in santasList)
            {
                if (item > 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {count} houses.");
            }
        }
    }
}
