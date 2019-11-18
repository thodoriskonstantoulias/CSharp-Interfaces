using System;
using System.Collections.Generic;
using System.Text;

namespace People.Library
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();
        Person GetPerson(int id);
        void AddPerson(Person person);
        void UpdatePerson(int id, Person updatedPerson);
        void DeletePerson(int id);
    }
}
