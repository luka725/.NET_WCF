using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalcService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        float AddNumbers(float n1, float n2);
        [OperationContract]
        float SubstractNumbers(float n1, float n2);
        [OperationContract]
        float DivideNumbers(float n1, float n2);
        [OperationContract]
        float MultiplyNumbers(float n1, float n2);
    }
}
