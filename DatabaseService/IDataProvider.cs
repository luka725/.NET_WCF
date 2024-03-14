using ClassLibraryDatabase;
using DatabaseService.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DatabaseService
{
    [ServiceContract]
    public interface IDataProvider
    {
        [OperationContract]
        CustomerDTO GetCustomerById(int customerId);
        [OperationContract]
        CustomerDTO[] GetCustomers(int pageNumber); 
    }
}
