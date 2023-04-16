using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>(); //created a List with all People
            Console.WriteLine("Enter a number of people: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)

            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter age:");
                int age = int.Parse(Console.ReadLine());
                Person person = new Person(name, age);
                people.Add(person);
            }
            people.Sort((age1, age2)=>age2.Age.CompareTo(age1.Age)); // Sort method to sort a person by Age
            Console.WriteLine("List of people:");
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
            Console.ReadKey();
        }
    }
}
