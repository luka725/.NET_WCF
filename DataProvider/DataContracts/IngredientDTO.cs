using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataProvider.DataContracts
{
    public class IngredientDTO
    {
        public int ingredient_id { get; set; }
        public string ingredient_name { get; set; }
        public string unit_of_measurement { get; set; }
        public int quantity_available { get; set; }
    }
}