using System;
using System.Collections.Generic;
using System.Linq;

namespace Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> theListOfFireLoL = Console.ReadLine().Split('#').ToList();

            List<int> finalList = new List<int>();

            int amountOfWater = int.Parse(Console.ReadLine());
            double effort = 0.0;
            int totalFire = 0;

            for (int i = 0; i < theListOfFireLoL.Count; i++)
            {
                string[] arrayOfCell = theListOfFireLoL[i].Split(" = ");

                if (arrayOfCell[0] == "High")
                {
                    int index = int.Parse(arrayOfCell[1]);
                    if (index >= 81 && index <= 125)
                    {
                        if (amountOfWater - index < 0)
                        {
                            continue;
                        }
                        else
                        {
                            finalList.Add(index);
                            amountOfWater -= index;
                            effort += 0.25 * index;
                            totalFire += index;
                            if(amountOfWater == 0)
                            {
                                break;
                            }
                        }
                    }
                }
                else if (arrayOfCell[0] == "Medium")
                {
                    int index = int.Parse(arrayOfCell[1]);
                    if (index >= 51 && index <= 80)
                    {
                        if (amountOfWater - index < 0)
                        {
                            continue;
                        }
                        else
                        {
                            finalList.Add(index);
                            amountOfWater -= index;
                            effort += 0.25 * index;
                            totalFire += index;
                            if (amountOfWater == 0)
                            {
                                break;
                            }
                        }
                    }
                }
                else if (arrayOfCell[0] == "Low")
                {
                    int index = int.Parse(arrayOfCell[1]);
                    if (index >= 1 && index <= 50)
                    {
                        if (amountOfWater - index < 0)
                        {
                            continue;
                        }
                        else
                        {
                            finalList.Add(index);
                            amountOfWater -= index;
                            effort += 0.25 * index;
                            totalFire += index;
                            if (amountOfWater == 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Cells:");
            foreach (var item in finalList)
            {
                Console.WriteLine($" - {item}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
