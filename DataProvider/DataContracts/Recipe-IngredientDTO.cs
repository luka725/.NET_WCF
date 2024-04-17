using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataProvider.DataContracts
{
    public class Reciepe_IngredientDTO
    {
        public int relation_id { get; set; }
        public int recipe_id { get; set; }
        public int ingredient_id { get; set; }
        public int quantity_required { get; set; }
    }
}