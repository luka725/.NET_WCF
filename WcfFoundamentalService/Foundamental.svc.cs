using FoundamentalClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfFoundamentalService.Models;

namespace WcfFoundamentalService
{
    public class Foundamental : IFoundamental
    {
        public PersonData GetPersonById(int personId)
        {
            using (var dbContext = new FoundamentalDataModel())
            {
                var person = dbContext.Persons.FirstOrDefault(p => p.Id == personId);

                if (person != null)
                {
                    return new PersonData
                    {
                        Id = person.Id,
                        FirstName = person.FirstName,
                        LastName = person.LastName,
                        PersonalId = person.PersonalId,
                        Email = person.Email
                    };
                }
                return null;
            }
        }
        public List<PersonData> GetAllPerson()
        {
            using (var dbContext = new FoundamentalDataModel())
            {
                List<Person> persons = dbContext.Persons.ToList();

                List<PersonData> personDataList = persons.Select(p => new PersonData
                {
                    Id = p.Id,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    FullName = p.FirstName + " " + p.LastName,
                    PersonalId = p.PersonalId,
                    Email = p.Email
                }).ToList();

                return personDataList;
            }
        }
        public void AddPerson(PersonData NewPerson)
        {
            using (var dbContext = new FoundamentalDataModel())
            {
                if (NewPerson.Id != 0)
                {
                    Person existingPerson = dbContext.Persons.Find(NewPerson.Id);

                    if (existingPerson != null)
                    {
                        existingPerson.FirstName = NewPerson.FirstName;
                        existingPerson.LastName = NewPerson.LastName;
                        existingPerson.PersonalId = NewPerson.PersonalId;
                        existingPerson.Email = NewPerson.Email;
                    }
                }
                else
                {
                    Person newPerson = new Person
                    {
                        FirstName = NewPerson.FirstName,
                        LastName = NewPerson.LastName,
                        PersonalId = NewPerson.PersonalId,
                        Email = NewPerson.Email
                    };
                    dbContext.Persons.Add(newPerson);
                }
                dbContext.SaveChanges();
            }
        }
        public void DeletePersonById(int personId)
        {
            using (var dbContext = new FoundamentalDataModel())
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
