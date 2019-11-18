using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace People.Library
{
    public class PersonRepository
    {
        //We create mock data for testing


        //public Person[] persons { get; set; }
        //public PersonRepository()
        //{
        //    persons = new Person[2];
        //    persons[0] = new Person { Id = 1, Name = "Ted", BirthDate = new DateTime(1991, 02, 19), Rating = 10 };
        //    persons[1] = new Person { Id = 2, Name = "Kostas", BirthDate = new DateTime(1981, 06, 15), Rating = 8 };
        //}
        //public Person[] GetPeople()
        //{
        //    return persons;
        //}

        //Let's say we want a list instead of an array
        public List<Person> persons { get; set; }
        public PersonRepository()
        {
            persons = new List<Person>()
            {
                new Person { Id = 1, Name = "Ted", BirthDate = new DateTime(1991, 02, 19), Rating = 10 },
                new Person { Id = 2, Name = "Kostas", BirthDate = new DateTime(1981, 06, 15), Rating = 8 }
            };
        }
        public List<Person> GetPeople()
        {
            return persons;
        }
        
        public Person GetPerson(int id)
        {
            var person =  persons.FirstOrDefault(x => x.Id == id);
            return person;
        }
    }
}
