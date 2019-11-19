using System;
using System.Collections.Generic;
using System.Text;

namespace People.Library
{
    public static class RepositoryFactory
    {
        //We creaty a Factory method to return the desired instance every time 
        //As the program extends we can add here 
        public static IPersonReader GetRepository(string repoType)
        {
            IPersonReader repo = null;
            switch (repoType)
            {
                case "Person":
                    repo = new PersonRepository();
                    break;
                default:
                    throw new ArgumentException("Invalid repository type");
            }
            return repo;
        }
    }
}
