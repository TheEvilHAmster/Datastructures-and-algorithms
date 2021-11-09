using System;

namespace Datastructures_and_algorithms
{
    public class Generator
    {
        int minLength = 10;
        int lowerBound = 1;
        int upperBound = 200;

        public int[] randomArray()
        {
            int length; 

            Console.Write("Please enter a length for the array: ");
            string input = Console.ReadLine();

            if(!Int32.TryParse(input, out length))
            {
                length = minLength;
            }

            return randomArray(length);
        }

        public int[] randomArray(int length)
        {
            int[] result = new int[length];
            
            Random rand = new Random();

            for (int i=0; i < length; i++)
            {
                result[i] = rand.Next(lowerBound, upperBound); 
            }

            return result;
        }
    }
}
