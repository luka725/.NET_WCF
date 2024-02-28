using FoundamentalClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfFoundamentalService
{
    [DataContract]
    public class PersonData
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string PersonalId { get; set; }

        [DataMember]
        public string Email { get; set; }
    }

    [ServiceContract]
    public interface IFoundamental
    {
        [OperationContract]
        List<PersonData> GetAllPerson();

        [OperationContract]
        void AddPerson(PersonData NewPerson);
        
        [OperationContract]
        void DeletePersonById(int personId);

        [OperationContract]
        PersonData GetPersonById(int personId);
    }
}
