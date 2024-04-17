using DataAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DataProvider
{
    public class ReciepeService : IReciepeService
    {
        public List<Recipe> GetAllReciepe()
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
