using System;

namespace _1._Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int party = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int currentCoins = 0;

            for (int day = 1; day <= days; day++)
            {
                if (day % 10 == 0)
                {
                    party -= 2;
                }
                if (day % 15 == 0)
                {
                    party += 5;
                }
                currentCoins += 50;
                currentCoins -= 2 * party;
                if(day % 3 == 0)
                {
                    currentCoins -= 3 * party;
                    if(day % 5 == 0)
                    {
                        currentCoins -= 2 * party;
                    }
                }
                if(day % 5 == 0)
                {
                    currentCoins += 20 * party;
                }
            }
            int coinsPerCompanion = currentCoins / party;
            Console.WriteLine($"{party} companions received {coinsPerCompanion} coins each.");
        }
    }
}
