using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfEvents = Console.ReadLine().Split('|').ToList();
            int currentEnergy = 100;
            int currentCoins = 100;


            for (int i = 0; i < listOfEvents.Count; i++)
            {
                List<string> eventA = listOfEvents[i].Split('-').ToList();

                if (eventA[0] == "rest")
                {
                    int addEnergy = int.Parse(eventA[1]);

                    if (currentEnergy + addEnergy > 100)
                    {
                        int difference = Math.Abs(100 - currentEnergy);
                        Console.WriteLine($"You gained {difference} energy.");
                        currentEnergy = 100;
                    }
                    else
                    {
                        currentEnergy += addEnergy;
                        Console.WriteLine($"You gained {addEnergy} energy.");
                    }
                    Console.WriteLine($"Current energy: {currentEnergy}.");
                }
                else if (eventA[0] == "order")
                {
                    int addCoins = int.Parse(eventA[1]);

                    if (currentEnergy - 30 < 0)
                    {
                        currentEnergy += 50;
                        Console.WriteLine($"You had to rest!");
                    }
                    else
                    {
                        currentEnergy -= 30;
                        currentCoins += addCoins;
                        Console.WriteLine($"You earned {addCoins} coins.");
                    }
                }
                else
                {
                    string ingredientToBuy = eventA[0];
                    int ingredientPrice = int.Parse(eventA[1]);

                    currentCoins -= ingredientPrice;

                    if (currentCoins >= 0)
                    {
                        Console.WriteLine($"You bought {ingredientToBuy}.");
                    }
                    else
                    {
                        currentCoins = 0;
                        Console.WriteLine($"Closed! Cannot afford {ingredientToBuy}.");
                        return;
                    }
                }
            }
            Console.WriteLine($"Day completed!");
            Console.WriteLine($"Coins: {currentCoins}");
            Console.WriteLine($"Energy: {currentEnergy}");
        }
    }
}
