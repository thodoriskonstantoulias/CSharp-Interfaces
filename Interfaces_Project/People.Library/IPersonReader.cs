using System.Collections.Generic;

namespace People.Library
{
    //Because of interface segragation principle we create a new interface with the methods that we trully need
    public interface IPersonReader
    {
        IEnumerable<Person> GetPeople();
        Person GetPerson(int id);
    }
}