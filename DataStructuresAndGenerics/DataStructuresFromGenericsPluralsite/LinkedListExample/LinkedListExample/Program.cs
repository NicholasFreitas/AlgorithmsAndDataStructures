using System;
using System.Collections.Generic;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //Doubly linked list
            //efficient for additions and removals
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(1);
            list.AddFirst(3);


            var first = list.First;

            list.AddAfter(first,10);



            foreach (var item in list)
            {

                Console.WriteLine($"{item}");

            }








        }
    }
}
