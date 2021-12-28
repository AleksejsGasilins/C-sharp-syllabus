using System;
using System.Collections.Generic;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> mySet1 = new HashSet<string>();
            mySet1.Add("one");
            mySet1.Add("two");
            mySet1.Add("three");
            mySet1.Add("four");
            mySet1.Add("five");

            Console.WriteLine("The elements in mySet1 are: ");

            foreach (var item in mySet1)
            {
                Console.WriteLine(item);
            }

            HashSet<string> mySet2 = new HashSet<string>();
            mySet2.Add("one");
            mySet2.Add("two");
            mySet2.Add("three");
            mySet2.Add("four");
            mySet2.Add("five");

            mySet1.ExceptWith(mySet2);

            Console.WriteLine("The elements in mySet1 are : ");

            foreach (var item in mySet1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Is it possible to add a duplicate?");

            HashSet<string> mySet3 = new HashSet<string>();
            mySet3.Add("ten");
            mySet3.Add("two");
            mySet3.Add("two");
            mySet3.Add("six");
            mySet3.Add("eight");
            mySet3.Add("five");
            mySet3.Add("five");

            List<string> myList = new List<string>();
            mySet3.Add("ten");
            mySet3.Add("two");
            mySet3.Add("two");
            mySet3.Add("six");
            mySet3.Add("eight");
            mySet3.Add("five");
            mySet3.Add("five");

            if (myList.Count == mySet3.Count)
            {
                Console.WriteLine("possible to add duplicated values.");
            }
            else
            {
                Console.WriteLine("It is not possible to add duplicates to the HashSet as it only stores unique characters!");
            }
        }
    }
}
