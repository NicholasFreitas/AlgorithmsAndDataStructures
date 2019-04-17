using System;
using System.Collections.Generic;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIFO - First In First Out data structure


            //Functions a LOT like a list
            Queue<Person> line = new Queue<Person>();

            //Every item added, gets added to the back of the line
            line.Enqueue( new Person() {Name = "Betty" } );
            line.Enqueue( new Person() {Name = "Veronica" } );
            line.Enqueue( new Person() {Name = "Archie" } );
            line.Enqueue( new Person() {Name = "Jughead" } );



            foreach (var person in line)
            {
                Console.WriteLine($"{person.Name}");
            }


            var dequeued = line.Dequeue();
            Console.WriteLine($"{dequeued.Name} has left the Queue");

            Console.WriteLine($"{line.Peek().Name} is next in line.");
                       
            Console.WriteLine();
            Console.WriteLine("Remove item from queue");

            foreach (var person in line)
            {
                Console.WriteLine($"{person.Name}");
            }

            

        }
    }
}
