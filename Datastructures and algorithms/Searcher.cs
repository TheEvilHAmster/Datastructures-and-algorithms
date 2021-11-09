using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures_and_algorithms
{
    class Searcher : Module
    {
        protected override IDictionary<string, string> _menu()
        {
            Console.WriteLine("Select search algorithm to test:");
            IDictionary<string, string> items = new Dictionary<string, string>();
            items.Add("Linear search", "linearSearch");
            return items;
        }

        public void linearSearch()
        {
            // Convert and verify that your input is a valid integer
            string input;
            int target;
            do
            {
                Console.Write("Select a number (integer) to search for: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out target));

            _linearSearch(target);
        }

        private bool _linearSearch(int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    Console.WriteLine($"The number {target} was found");
                    return true;
                }
            }
            Console.WriteLine($"The tearet number {target} wasn't found");
            return false;
        }

        public Searcher()
        {
            this.generator = new Generator();
            numbers = generator.randomArray(10);
        }
    }
}
