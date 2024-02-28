using FoundamentClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfFoundamentalService
{
    [ServiceContract]
    public interface IFoundamental
    {
        [OperationContract]
        List<Person> GetAllPerson();

        [OperationContract]
        void AddPerson(string Fname, string Lname, string Pid, string Email);
        [OperationContract]
        void DeletePersonById(int personId);
    }
}
