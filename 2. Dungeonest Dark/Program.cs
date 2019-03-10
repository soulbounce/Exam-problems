using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dungeonRooms = Console.ReadLine().Split('|').ToList();

            int currentHP = 100;
            int currentGold = 0;

            for (int i = 0; i < dungeonRooms.Count; i++)
            {
                string[] room = dungeonRooms[i].Split();

                if(room[0] == "potion")
                {
                    int potion = int.Parse(room[1]);

                    if(currentHP + potion > 100)
                    {
                        int amountHealed = 100 - currentHP;
                        Console.WriteLine($"You healed for {amountHealed} hp.");
                        currentHP = 100;
                    }
                    else
                    {
                        currentHP += potion;
                        Console.WriteLine($"You healed for {potion} hp.");
                    }
                    Console.WriteLine($"Current health: {currentHP} hp.");
                }
                else if(room[0] == "chest")
                {
                    int goldFound = int.Parse(room[1]);
                    currentGold += goldFound;
                    Console.WriteLine($"You found {goldFound} coins.");
                }
                else
                {
                    string monster = room[0];
                    int monsterAttack = int.Parse(room[1]);

                    if(currentHP - monsterAttack <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                    else
                    {
                        currentHP -= monsterAttack;
                        Console.WriteLine($"You slayed {monster}.");
                    }
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {currentGold}");
            Console.WriteLine($"Health: {currentHP}");
        }
    }
}
