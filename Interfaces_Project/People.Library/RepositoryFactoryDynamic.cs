using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace People.Library
{
    //Factory method implemented but this dynamic which means it is compiled at runtime. This is more efficient because with any 
    //change it does not need recompiling
    public class RepositoryFactoryDynamic
    {
        //Comparing with the factory method this does not take any parameters
        public static IPersonRepository GetRepository()
        {
            //This congig is at app.config of a project- Not implemented here just showing the steps
            string repoName = ConfigurationManager.AppSettings["RepositoryType"];
            Type repositoryType = Type.GetType(repoName);
            object repository = Activator.CreateInstance(repositoryType);
            IPersonRepository personRepo = repository as IPersonRepository;
            return personRepo;
        }
    }
}
