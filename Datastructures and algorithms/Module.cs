
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Datastructures_and_algorithms
{
    public class Module
    {
        protected Generator generator;
        protected int[] numbers;
        protected int swapCount = 0;

        protected virtual IDictionary<string, string> _menu()
        {
            IDictionary<string, string> dummy = new Dictionary<string, string>();
            return dummy;
        }
    
        public void menu()
        {
            Console.Clear();
            string method = "";

            while (method != "back")
            {
                Console.Write("Current data: ");
                displayArray(numbers);

                IDictionary<string, string> items = _menu();
                items.Add("Generate new array", "setNewArray");
                items.Add("Go back", "back");

                method = Samuels1Thingy.menuChoice(items);
                runMethod(method);
            }
        }

        private void runMethod(string methodName)
        {
            if (methodName != "back")
            {
                Type thisType = this.GetType();
                MethodInfo methodInfo = thisType.GetMethod(methodName);
                methodInfo.Invoke(this, new object[] { });
            }
        }

        public void setNewArray()
        {
            numbers = generator.randomArray();
            menu();
        }

        protected void displayArray(int[] array, bool showSwapCount = false)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);

                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("\n");

            if (showSwapCount)
            {
                Console.WriteLine("Swaps performed: " + swapCount);
                swapCount = 0;
            }
        }

        protected void swap(int[] arr, int index_a, int index_b)
        {
            var temp = arr[index_a];
            arr[index_a] = arr[index_b];
            arr[index_b] = temp;
            swapCount++;
        }
    }
}