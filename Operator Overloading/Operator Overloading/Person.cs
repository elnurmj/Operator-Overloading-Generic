using System;
using System.Collections.Generic;
using System.Text;

namespace Operator_Overloading
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public static bool operator >(Person person, Person person1)
        {
            return person.Age > person1.Age;
        }
        public static bool operator <(Person person, Person person1)
        {
            return person.Age < person1.Age;
        }
    }
    
    
}
