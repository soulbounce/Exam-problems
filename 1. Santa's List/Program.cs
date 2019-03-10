using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split('&').ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Finished!")
                {
                    break;
                }
                if (command[0] == "Bad")
                {
                    string addName = command[1];

                    if (!names.Contains(addName))
                    {
                        names.Insert(0, addName);
                    }
                }
                else if (command[0] == "Good")
                {
                    string removeName = command[1];

                    if (names.Contains(removeName))
                    {
                        names.Remove(removeName);
                    }
                }
                else if (command[0] == "Rename")
                {
                    string oldName = command[1];
                    string newName = command[2];

                    if (names.Contains(oldName))
                    {
                        int indexOfOldName = names.IndexOf(oldName);
                        names.RemoveAt(indexOfOldName);
                        names.Insert(indexOfOldName, newName);
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    string rearrange = command[1];

                    if (names.Contains(rearrange))
                    {
                        int indexRearrange = names.IndexOf(rearrange);
                        names.RemoveAt(indexRearrange);
                        names.Add(rearrange);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", names));
        }
    }
}
