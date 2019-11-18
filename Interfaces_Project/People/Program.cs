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
            Console.WriteLine("--------------");

            //Below we call the one service we created using the interface 
            //If we ever want to use a new service, we create a new service repo implementing the interface and we change the code only below in the declaration
            //That's the beauty of interfaces

            //IPersonRepository list_service = new PersonRepository();
            IPersonRepository list_service = RepositoryFactory.GetRepository("Person");

            var personToAdd = new Person { Id = 3, Name = "Mary" };
            list_service.AddPerson(personToAdd);
            IEnumerable<Person> list_service_items = list_service.GetPeople();
            foreach(var person in list_service_items)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
