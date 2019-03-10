using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            while(true)
            {
                string[] command = Console.ReadLine().Split(" - ");

                if(command[0] == "Retire!")
                {
                    break;
                }

                if(command[0] == "Start")
                {
                    string questToAdd = command[1];

                    if(!journal.Contains(questToAdd))
                    {
                        journal.Add(questToAdd);
                    }
                }
                else if(command[0] == "Complete")
                {
                    string questToComplete = command[1];

                    if (journal.Contains(questToComplete))
                    {
                        journal.Remove(questToComplete);
                    }
                }
                else if(command[0] == "Renew")
                {
                    string questToRenew = command[1];
                    if (journal.Contains(questToRenew))
                    {
                        int indexOfQuest = journal.IndexOf(questToRenew);
                        journal.RemoveAt(indexOfQuest);
                        journal.Add(questToRenew);
                    }
                }
                else if(command[0] == "Side Quest")
                {
                    string[] novMasiv = command[1].Split(':');

                    string questToCheck = novMasiv[0];
                    string sideQuestToCheck = novMasiv[1];

                    if(journal.Contains(questToCheck))
                    {
                        if(!journal.Contains(sideQuestToCheck))
                        {
                            int indexOfQuest = journal.IndexOf(questToCheck);
                            journal.Insert(indexOfQuest + 1, sideQuestToCheck);
                        }
                    }
                }
                
            }
            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
