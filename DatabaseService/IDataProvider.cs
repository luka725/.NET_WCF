using ClassLibraryDatabase;
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
        Customer GetCustomerById(int customerId);
    }
}
