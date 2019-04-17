using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array
            Employee[] employees = new Employee[] { 

                new Employee{ FirstName = "John"  ,LastName = "Smith"  , Age = 19 },
                new Employee{ FirstName = "Allen" ,LastName = "Turing" , Age = 19 }

            };


            foreach (var employee in employees)
            {
                Console.WriteLine($" Employee Information : {employee.FirstName} {employee.LastName} - {employee.Age}");
            }


            //Not from video, the for tends to be really efficient because you're accessing the object directly.
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Emp Info: {employees[i].FirstName} {employees[i].LastName} : {employees[i].Age}");
                
            }

            //Arrays tend to be less useful when you want to add, remove, append and so on.
            //Arrays have a fixed size.

            //We can resize
            Array.Resize(ref employees, 10);

            /* This can lead to more complexity in algorithm construction.
             Also, it can lead to performance issues if the array is constantly resized.*/


        }
    }
}
