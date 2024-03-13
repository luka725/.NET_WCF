using ClassLibraryDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DatabaseService
{
    public class DataProvider : IDataProvider
    {
        public Customer GetCustomer()
        {
            using (var dbContext = new DatabaseModel())
            {
                int customerIdToRetrieve = 1;

                var customer = dbContext.Customers
                                        .FirstOrDefault(c => c.CustomerID == customerIdToRetrieve);

                return customer;
            }
        }
    }
}
