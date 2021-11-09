using System;
using System.Collections.Generic;

namespace Datastructures_and_algorithms
{
    public class Samuels1Thingy
    {
        void menything()
        {
            {
                IDictionary<string, string> modules = new Dictionary<string, string>();
                modules.Add("Search", "search");
                modules.Add("Sort", "sort");
                modules.Add("Exit", "exit");

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to DSA exercises! Select topic:");
                    string choice = menuChoice(modules);

                    switch (choice)
                    {
                        case "search":
                            var searcher = new Searcher();
                            searcher.menu();
                            break;
                        case "sort":
                            var sorter = new Sorter();
                            sorter.menu();
                            break;
                    }
                }
            }
        }
        
        public static string menuChoice(IDictionary<string, string> items)
        {
            string[] options = new string[items.Count];
            int i = 0;

            foreach(KeyValuePair<string, string> kvp in items)
            {
                Console.WriteLine((i + 1) + ") " + kvp.Key);
                options[i++] = kvp.Value;
            }

            string result, input = Console.ReadLine();
            int choice;
            
            if (!Int32.TryParse(input, out choice) || choice == 0 || choice > items.Count)
            {
                Console.WriteLine("Invalid choice...");
                result = menuChoice(items);
            }
            else
            {
                result = options[choice - 1];
            }

            if (result == "exit")
            {
                Console.WriteLine("Bye!");
                Environment.Exit(0);
            }
            return result;
        }
    }
}