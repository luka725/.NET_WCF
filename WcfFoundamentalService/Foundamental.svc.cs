using FoundamentalClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfFoundamentalService.Common;
using WcfFoundamentalService.DataContracts;

namespace WcfFoundamentalService
{
    public class Foundamental : IFoundamental
    {
        public PersonDTO GetPersonById(int personId)
        {
            using (var dbContext = new FoundamentalDataModel())
            {
                var person = dbContext.Persons.FirstOrDefault(p => p.Id == personId);

                if (person != null)
                {
                    return AutoMapperConfig.Mapper.Map<PersonDTO>(person);
                }
                return null;
            }
        }
        public List<PersonDTO> GetAllPerson()
        {
            using (var dbContext = new FoundamentalDataModel())
            {
                var persons = dbContext.Persons.ToList();
                return persons.Select(p => AutoMapperConfig.Mapper.Map<PersonDTO>(p)).ToList();
            }
        }
        public void AddPerson(PersonDTO NewPerson)
        {
            using (var dbContext = new FoundamentalDataModel())
            {
                if (NewPerson.Id != 0)
                {
                    Person existingPerson = dbContext.Persons.Find(NewPerson.Id);

                    if (existingPerson != null)
                    {
                        AutoMapperConfig.Mapper.Map(NewPerson, existingPerson);
                    }
                }
                else
                {
                    dbContext.Persons.Add(AutoMapperConfig.Mapper.Map<Person>(NewPerson));
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
