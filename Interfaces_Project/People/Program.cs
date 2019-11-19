using People.Library;
using People.Library.Services_Repo;
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
            Console.WriteLine("Without interface example");
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
            //IPersonRepository list_service = RepositoryFactory.GetRepository("Person");
            Console.WriteLine("Interface and factory method example");
            IPersonReader list_service = RepositoryFactory.GetRepository("Person");

            //var personToAdd = new Person { Id = 3, Name = "Mary" };
            //list_service.AddPerson(personToAdd);
            IEnumerable<Person> list_service_items = list_service.GetPeople();
            foreach(var person in list_service_items)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine("--------------");

            //Note : We have to be careful and not use a lot of interfaces because there is the danger that the code will become more complex
            //Go to implentation is weird when using interfaces. Debugging and step into is a solution that take us to the correct implementation

            //Dependency Injection example 
            Console.WriteLine("Dependency injection example");
            //If we ever change the service we only modify the following line and we are done 
            IPersonReader depend_inj_instance = new PersonRepository();
            var generalRepo = new GeneralDIrepository(depend_inj_instance);
            IEnumerable<Person> list_service_items2 = generalRepo.GetAll();
            foreach (var person in list_service_items2)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
