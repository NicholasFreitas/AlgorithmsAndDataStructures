using System;
using System.Collections.Generic;

namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashset
            //A unique set of items, it will not allow you to store duplicates inside.
            //Workes VERY well with value types, reference types and objects require more work.


            HashSet<int> set = new HashSet<int>();

            set.Add(3);
            set.Add(5);
            set.Add(5); //We add a second five, the hashset ignores the add because all it cares about is UNIQUE values.


            //It will only every take in unique values
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }


            //intersect with two sets
            var _setOne = new HashSet<int>() { 1, 2, 3, 4, 6 };
            var _setTwo = new HashSet<int>() { 1, 2, 3, 5, 6 };
            _setOne.IntersectWith(_setTwo);


            Console.WriteLine("--Intersect--");
            //Will leave behind only the items present in BOTH sets
            foreach (var item in _setOne)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
            Console.WriteLine("---Union---");
            //uniontwith two sets
            var _setThree = new HashSet<int>() { 1, 2, 3, 4, 6 };
            var _setFour = new HashSet<int>() { 1, 2, 3, 5, 6 };
            _setThree.UnionWith(_setFour);

            //Will leave behind only the items present in BOTH sets
            foreach (var item in _setThree)
            {
                Console.WriteLine($"{item}");
            }




            Console.WriteLine();
            Console.WriteLine("---Symmetric---");
            //uniontwith two sets
            var _setFive = new HashSet<int>() { 1, 2, 3, 4, 6 };
            var _setSix = new HashSet<int>() { 1, 2, 3, 5, 6 };
            _setFive.SymmetricExceptWith(_setSix);

            //Will be a collection of items from both sets not present in opposing sets
            foreach (var item in _setFive)
            {
                Console.WriteLine($"{item}");
            }





        }
    }
}
