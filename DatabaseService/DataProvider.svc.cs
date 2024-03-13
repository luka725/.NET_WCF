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
        public Customer GetCustomerById(int customerId = 0)
        {
            using (var dbContext = new DatabaseModel())
            {
                customerId = 1;

                var customer = dbContext.Customers
                                        .FirstOrDefault(c => c.CustomerID == customerId);

                return customer;
            }
        }
    }
}
