using FoundamentalClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfFoundamentalService.Models;

namespace WcfFoundamentalService
{
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
