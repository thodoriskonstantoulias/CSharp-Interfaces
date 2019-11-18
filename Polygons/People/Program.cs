using People.Library;
using System;
using System.Collections.Generic;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach accepts IEnumerable so it is maintainable if something changes
            //So declaring the variable as IEnumerable if we change our data structure in the future, the code here stays the same
            var personRepo = new PersonRepository();
            IEnumerable<Person> persons = personRepo.GetPeople();
            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
