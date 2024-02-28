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
            using (var dbContext = new FoundamentalModel())
            {
                return dbContext.Persons.ToList();
            }
        }
        public void AddPerson(string Fname, string Lname, string Pid, string Email)
        {
            using (var dbContext = new FoundamentalModel())
            {
                Person newPerson = new Person
                {
                    FirstName = Fname,
                    LastName = Lname,
                    PersonalId = Pid,
                    Email = Email
                };
                dbContext.Persons.Add(newPerson);
                dbContext.SaveChanges();
            }
        }
        public void DeletePersonById(int personId)
        {
            using (var dbContext = new FoundamentalModel())
            {
                var personToDelete = dbContext.Persons.Find(personId);

                if (personToDelete != null)
                {
                    dbContext.Persons.Remove(personToDelete);
                    dbContext.SaveChanges();
                }
            }
        }

    }
}
