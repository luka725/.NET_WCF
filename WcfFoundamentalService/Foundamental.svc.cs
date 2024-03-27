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
using System.Transactions;
using System.Messaging;


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
            try
            {
                using (var scope = new TransactionScope())
                {
                    using (var dbContext = new FoundamentalDataModel())
                    {
                        var existingPerson = dbContext.Persons.FirstOrDefault(p => p.Email == NewPerson.Email);
                        if (existingPerson == null)
                        {
                            dbContext.Persons.Add(AutoMapperConfig.Mapper.Map<Person>(NewPerson));
                            dbContext.SaveChanges();
                            SendMessageToClient("Person inserted successfully.");
                            scope.Complete();
                        }
                        else
                        {
                            SendMessageToClient("Person with the provided email already exists. Rolling back transaction.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                SendMessageToClient("An error occurred: " + ex.Message);
            }
        }
        public void UpdatePerson(PersonDTO NewPerson)
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
        public void SendMessageToClient(string message)
        {
            MessageQueue messageQueue = new MessageQueue(@".\Private$\MyQueue");
            messageQueue.Send(message);
        }
    }
}
