using System;
using System.Collections.Generic;
using System.Text;


namespace Datastructures_and_algorithms
{
    class Sorter : Module
    {
        protected override IDictionary<string, string> _menu()
        {
            Console.WriteLine("\nSelect sorting algorithm to test:");
            IDictionary<string, string> items = new Dictionary<string, string>();
            items.Add("Selection sort", "selectionSort");
            return items;
        }

        public void selectionSort()
        {
            int[] copy = new int[numbers.Length];
            numbers.CopyTo(copy, 0);
            _selectionSort(copy);

            Console.Write("Result: ");
            displayArray(copy, true);
            Console.Write("\n");
        }

        private int[] _selectionSort(int[] arr)
        {
            // int[] arrayToSort = arr;
            // int n = arrayToSort.Length, compare;
            //
            // for (int i = 0; i < n-1; i++) {
            //     int minIndex = i;
            //     
            //     for ( compare = i+1; compare < n; compare++) {
            //         if (arrayToSort[minIndex] > arrayToSort[compare]) {
            //             minIndex = compare;
            //         }
            //     }
            //     swap(arrayToSort,i, compare);
            // }

            int[] arrayOfInt = arr;
            int minIndex; 
            for (int i = 0; i < arrayOfInt.Length - 1; i++)
            {
                minIndex = i;

                for (int compare = i + 1; compare < arrayOfInt.Length; compare++)
                {
                    if (arrayOfInt[compare] < arrayOfInt[minIndex])
                    {
                        minIndex = compare;
                    }
                }
                swap(arrayOfInt,i, minIndex);
                
            }

            return arrayOfInt;
        }
        
        

        public Sorter()
        {
            this.generator = new Generator();
            numbers = generator.randomArray(10);
        }
    }
}
