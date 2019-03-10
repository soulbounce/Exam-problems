using System;

namespace _01.__The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());

            double currentWater = numberOfPeople * waterPerDayPerPerson * days;
            double currentFood = numberOfPeople * foodPerDayPerPerson * days;

            for (int i = 1; i <= days; i++)
            {
                double energyLost = double.Parse(Console.ReadLine());
                groupEnergy -= energyLost;

                if (groupEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {currentFood:f2} food and {currentWater:f2} water.");
                    return;
                }

                if (i % 2 == 0)
                {
                    groupEnergy += groupEnergy * 0.05;
                    currentWater -= currentWater * 0.30;
                }
                if(i % 3 == 0)
                {
                    currentFood -= currentFood / numberOfPeople;
                    groupEnergy += groupEnergy * 0.10;
                }

                
            }
            Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
        }
    }
}
