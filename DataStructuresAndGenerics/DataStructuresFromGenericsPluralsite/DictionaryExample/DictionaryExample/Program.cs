using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //Efficient for searches, unique key value, efficient insets and removal
            // Dictionary<string, Person> _dictionary = new Dictionary<string, Person>();
            SortedDictionary<string, Person> _dictionary = new SortedDictionary<string, Person>();
            _dictionary.Add("Nick",new Person("Nicholas","Freitas",40));
            _dictionary.Add("Tom",new Person("Tom","Lebreux",24));
            _dictionary.Add("Ian",new Person("Ian","Tremblay",25));
            _dictionary.Add("Dom",new Person("Domenic","Sacereccia",23));
            _dictionary.Add("Abdul",new Person("Abdul","Mirza",22));
            _dictionary.Add("Remy",new Person("Remy","Chaurand",24));
            
            //you can access items directly by key
            var nick = _dictionary["Nick"];

            Console.WriteLine(nick.FirstName + " : " + nick.LastName);


            foreach (var definition in _dictionary)
            {
                Console.WriteLine($"{definition.Key} - {definition.Value.FirstName} {definition.Value.LastName}");
            }


            if (_dictionary.ContainsKey("Nicole"))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");


            _dictionary.Remove("Abdul");

            foreach (var definition in _dictionary)
            {
                Console.WriteLine($"{definition.Key} - {definition.Value.FirstName} {definition.Value.LastName}");
            }



            // least amoung of memory and allows to iterate as quickly as possible
            SortedList<string, Person> _personList = new SortedList<string, Person>();

            // Unique Values
            SortedSet<Person> _personSet = new SortedSet<Person>();

        }
    }
}
