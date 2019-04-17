using System;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIFO - Last In First Out


            //Functions a LOT like a list
            Stack<Person> _stack = new Stack<Person>();

            //Every item added, gets added to the back of the line
            _stack.Push(new Person() { Name = "Betty" });
            _stack.Push(new Person() { Name = "Veronica" });
            _stack.Push(new Person() { Name = "Archie" });
            _stack.Push(new Person() { Name = "Jughead" });
                       
            foreach (var person in _stack)
            {
                Console.WriteLine($"{person.Name}");
            }

            var poppedPerson = _stack.Pop();
            Console.WriteLine($"{poppedPerson.Name} has been popped.");

            var peeked = _stack.Peek();
            Console.WriteLine($"{peeked.Name} will be popped next");


            Console.WriteLine();

            foreach (var person in _stack)
            {
                Console.WriteLine($"{person.Name}");
            }


        }
    }
}
