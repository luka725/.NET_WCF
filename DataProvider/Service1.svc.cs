using DataAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DataProvider
{
    public class Service1 : IService1
    {
        public List<Recipe> GetData()
        {
            List<Recipe> allRecipes;
            using (var context = new ReciepeDB())
            {
                allRecipes = context.Recipes.ToList();
            }
            return allRecipes;
        }
    }
}
