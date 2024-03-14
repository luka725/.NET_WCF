using ClassLibraryDatabase;
using DatabaseService.Common;
using DatabaseService.DataContracts;
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
        public CustomerDTO GetCustomerById(int customerId = 0)
        {
            using (var dbContext = new DatabaseModel())
            {
                customerId = 1;

                var customer = dbContext.Customers
                                        .FirstOrDefault(c => c.CustomerID == customerId);

                return AutoMapperConfig.Mapper.Map<CustomerDTO>(customer);
            }
        }
        public CustomerDTO[] GetCustomers(int pageNumber = 1)
        {
            using (var dbContext = new DatabaseModel())
            {
                int pageSize = 20;

                var customers = dbContext.Customers
                              .OrderBy(c => c.CustomerID)
                              .Skip((pageNumber - 1) * pageSize)
                              .Take(pageSize)
                              .ToList();
                return AutoMapperConfig.Mapper.Map<CustomerDTO[]>(customers);
            }
        }
    }
}
