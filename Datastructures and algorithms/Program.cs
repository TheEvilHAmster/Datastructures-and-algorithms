using System;
using System.Collections.Generic;

namespace Datastructures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // CustomLinkedList<string> list = new CustomLinkedList<string>
            // {
            //     Head = null
            // };
            //
            // list.Add("yoo");
            // list.Add("3");
            // list.Add("last");
            // list.Add("me as well");
            // Console.WriteLine(list.Count);
            //
            // for (int i = 0; i < 4; i++)
            // {
            //     Console.WriteLine(list.GetNodeAtIndex(i));
            // }
            
            Console.WriteLine("Add First:");
            MyLinkedList myList1 = new MyLinkedList();

            myList1.AddFirst("Hello");
            myList1.AddFirst("Magical");
            myList1.AddFirst("World");
            myList1.printAllNodes();

            Console.WriteLine();

            Console.WriteLine("Add Last:");
            MyLinkedList myList2 = new MyLinkedList();

            myList2.AddLast("Hello");
            myList2.AddLast("Magical");
            myList2.AddLast("World");
            myList2.printAllNodes();

            Console.ReadLine();
        }
    }
}