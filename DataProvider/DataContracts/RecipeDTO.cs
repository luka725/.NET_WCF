 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataProvider.DataContracts
{
    public class RecipeDTO
    {
        public int recipe_id { get; set; }
        public string recipe_name { get; set; }
        public string recipe_description { get; set; }
        public string recipe_instructions { get; set; }
    }
}