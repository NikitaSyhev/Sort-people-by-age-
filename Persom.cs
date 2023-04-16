using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
       // public string favoritetSeason { get; set; }
        public Person(string name, int age)

        {
            Name = name;
            Age = age;
         //   this.favoritetSeason = favoritetSeason; 
        }
    }
}
