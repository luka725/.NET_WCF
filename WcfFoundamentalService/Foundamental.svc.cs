using FoundamentClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfFoundamentalService
{
    public class Foundamental : IFoundamental
    {
        public List<Person> GetAllPerson()
        {
            using (var db = new FoundamentalModel())
            {
                var persons = db.Persons.ToList();
                return persons;
            }
        }
    }
}
