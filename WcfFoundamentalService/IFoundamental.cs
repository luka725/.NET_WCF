using FoundamentalClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfFoundamentalService.DataContracts;

namespace WcfFoundamentalService
{
    [ServiceContract]
    public interface IFoundamental
    {
        [OperationContract]
        List<PersonDTO> GetAllPerson();

        [OperationContract]
        void AddPerson(PersonDTO NewPerson);

        [OperationContract]
        void UpdatePerson(PersonDTO NewPerson);

        [OperationContract]
        void DeletePersonById(int personId);

        [OperationContract]
        PersonDTO GetPersonById(int personId);

        [OperationContract]
        void SendMessageToClient(string message);
    }
}
