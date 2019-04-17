using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            List<Employee> employees = new List<Employee> {

                new Employee{ FirstName = "John"  ,LastName = "Smith"  , Age = 19 },
                new Employee{ FirstName = "Allen" ,LastName = "Turing" , Age = 19 }

            };

            Console.WriteLine(employees.Capacity); 
            foreach (var employee in employees)
            {
            //  Console.WriteLine($" Employee Information : {employee.FirstName} {employee.LastName} - {employee.Age}");
            }


            //Like an array you can index into the List
            for (int i = 0; i < employees.Count; i++)
            {
            //  Console.WriteLine($"Emp Info: {employees[i].FirstName} {employees[i].LastName} : {employees[i].Age}");

            }


            //*The nifty bit here, is unlike an array, the list allows me to add new items.*//
            employees.Add( new Employee() { FirstName = "Jane", LastName="Doe", Age=32 } );
            employees.Add(new Employee() { FirstName = "Jane", LastName = "Doe", Age = 32 });
            employees.Add(new Employee() { FirstName = "Jane", LastName = "Doe", Age = 32 });

            //And as we add items to our array, the capacity, the total number of items, increases
            //Note here, it simply doubles and will continue to do so.
            //Which can be extremely inefficient.

            Console.WriteLine(employees.Capacity);








        }
    }
}
