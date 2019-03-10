using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Cooking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sum = 0;
            double average = 0;
            string daBudi = "";
            string dabudiOriginal = "";
            bool isgood = false;
            double newAverage = 0;

            while (true)
            {
                if (command == "Bake It!")
                {
                    if (newAverage > average && daBudi.Length < dabudiOriginal.Length || newAverage == average)
                    {
                        Console.WriteLine($"Best Batch quality: {sum}");
                        Console.WriteLine(string.Join(' ', daBudi));
                    }
                    else
                    {
                        Console.WriteLine($"Best Batch quality: {sum}");
                        Console.WriteLine(string.Join(' ', dabudiOriginal));
                    }
                    break;
                }

                List<int> commands = command.Split('#').Select(int.Parse).ToList();

                int newSum = commands.Sum();

                if (newSum > sum)
                {
                    sum = newSum;
                    daBudi = string.Join(' ', commands);
                }
                else if (newSum == sum)
                {
                    newAverage = commands.Average();

                    if (newAverage > average)
                    {
                        average = newAverage;
                        dabudiOriginal = daBudi;
                        daBudi = string.Join(' ', commands);
                    }
                    else if (newAverage == average)
                    {
                        int countBest = commands.Count;
                        if (commands.Count < countBest)
                        {
                            countBest = commands.Count;
                            daBudi = string.Join(' ', commands);
                        }
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
