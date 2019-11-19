using System;
using System.Collections.Generic;
using System.Text;

namespace People.Library.Services_Repo
{
    //We create this class to show the use of dependency injection
    //If we ever change the service that we use this class remain the same 
    public class GeneralDIrepository
    {
        private readonly IPersonReader personReader;

        public GeneralDIrepository(IPersonReader personReader)
        {
            this.personReader = personReader;
        }
        public IEnumerable<Person> GetAll()
        {
            return personReader.GetPeople();
        }
    }
}
