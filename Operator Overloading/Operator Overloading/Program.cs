using System;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            DataList<Person> people = new DataList<Person>();

            Person person = new Person("Elnur", "Ceferov",21);
            Person person1 = new Person("Emin", "Kazim", 22);
            Person person2 = new Person("Hezret", "Niftelizade", 25);
            Person person3 = new Person("Sadiq", "Abdullayev", 16);

            people.AddItems(person);
            people.AddItems(person1);
            people.AddItems(person2);
            people.AddItems(person3);

            people.GetSortedAgeItems();

            Console.WriteLine(person.Age > person1.Age);
            Console.WriteLine(person2.Age > person3.Age);




        }
    }
}
