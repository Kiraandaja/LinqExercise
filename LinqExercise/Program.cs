using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sum = numbers.Sum();
            var avg = numbers.Average();
            Console.WriteLine($"Sum: {sum}");


            //TODO: Print the Average of numbers
            Console.WriteLine($"Average: {avg}");

            //TODO: Order numbers in ascending order and print to the console
            var Ascending = numbers.OrderBy(num => num);
            Console.WriteLine("Ascending");
            foreach ( var num in Ascending)
            {
                Console.WriteLine(num);
            }

            //TODO: Order numbers in decsending order adn print to the console
            var Descending = numbers.OrderByDescending(num => num);
            Console.WriteLine("Descending");
            foreach (var num in Descending)
            {
                Console.WriteLine(num); 
            }

            //TODO: Print to the console only the numbers greater than 6
            var greaterThanSix = numbers.Where(num => num > 6);

            Console.WriteLine("Greater than six:");
            foreach (var item in greaterThanSix)
            {
                Console.WriteLine(item);
            }

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("First 4 numbers ascending.");
            foreach (var num in Ascending.Take (4))
            {
                Console.Write(num);
            }
            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 28;
            Console.WriteLine("My age.");
            foreach (var item in numbers.OrderByDescending(num =>num))
            {
                Console.WriteLine(item);
            }
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            var filtered = employees.Where(person => person.FirstName.StartsWith('S') || person.FirstName.StartsWith('S')).OrderBy(person => person.FirstName);

            Console.WriteLine("C or S Employees");
            foreach (var employee in filtered)
            {
                Console.WriteLine(employee.FullName);
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var overTwentySix = employees.Where(person => person.Age > 26).OrderBy(employees => employees.Age).ThenBy(employees => employees.FirstName);
            foreach(var person in overTwentySix)
            {
                Console.WriteLine($"Full Name {person.FullName} Age {person.Age} ");
            }

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            var years = employees.Where(employees => employees.YearsOfExperience <= 10 && employees.Age > 35);
             var  sumOfYearsOfExperience = employees.Sum(employees => employees.YearsOfExperience);
             var  avgOfYearsOfExperience = employees.Average(employees => employees.YearsOfExperience);

            Console.WriteLine($"Sum {sumOfYearsOfExperience} Average {avgOfYearsOfExperience}");
            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("first", "lastName", 98, 1)).ToList();

            foreach (var employess in employees)
            {
                Console.WriteLine($"First Name {employees.FirstName} Age {employees.Age}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
