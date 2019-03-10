using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collectionsOfWords = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Stop")
                {
                    break;
                }
                if (command[0] == "Delete")
                {
                    int indexOfNumberToDelete = int.Parse(command[1]);

                    if (indexOfNumberToDelete + 1 >= 0 && indexOfNumberToDelete + 1 < collectionsOfWords.Count)
                    {
                        collectionsOfWords.RemoveAt(indexOfNumberToDelete + 1);
                    }
                }
                else if (command[0] == "Swap")
                {
                    string word1 = command[1];
                    string word2 = command[2];

                    if (collectionsOfWords.Contains(word1) && collectionsOfWords.Contains(word2))
                    {
                        int indexOfWord1 = collectionsOfWords.IndexOf(word1);
                        int indexOfWord2 = collectionsOfWords.IndexOf(word2);

                        string tmp = collectionsOfWords[indexOfWord1];
                        collectionsOfWords[indexOfWord1] = collectionsOfWords[indexOfWord2];
                        collectionsOfWords[indexOfWord2] = tmp;
                    }

                }
                else if (command[0] == "Put")
                {
                    string wordToPut = command[1];
                    int indexToPutWord = int.Parse(command[2]);

                    if (indexToPutWord > collectionsOfWords.Count - 1 && indexToPutWord - 1 >= 0 && indexToPutWord - 1 <= collectionsOfWords.Count)
                    {
                        collectionsOfWords.Insert(indexToPutWord - 1, wordToPut);
                    }
                    else if (indexToPutWord <= collectionsOfWords.Count - 1 && indexToPutWord - 1 >= 0 && indexToPutWord - 1 <= collectionsOfWords.Count)
                    {
                        collectionsOfWords.Insert(indexToPutWord - 1, wordToPut);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command[0] == "Sort")
                {
                    collectionsOfWords.Sort();
                    collectionsOfWords.Reverse();
                }
                else if (command[0] == "Replace")
                {
                    string word1 = command[1];
                    string word2 = command[2];

                    if (collectionsOfWords.Contains(word2))
                    {
                        int indexOfWordToReplace = collectionsOfWords.IndexOf(word2);
                        collectionsOfWords.RemoveAt(indexOfWordToReplace);
                        collectionsOfWords.Insert(indexOfWordToReplace, word1);
                    }

                }
            }
            Console.WriteLine(string.Join(' ', collectionsOfWords));
        }
    }
}
