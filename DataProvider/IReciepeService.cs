using DataAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DataProvider
{
    [ServiceContract]
    public interface IReciepeService
    {
        [OperationContract]
        List<Recipe> GetAllReciepe();
    }
}
