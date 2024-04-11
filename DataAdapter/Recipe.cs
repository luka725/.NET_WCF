namespace DataAdapter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Recipe
    {
        [Key]
        [Column(Order = 0)]
        public int recipe_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(80)]
        public string recipe_name { get; set; }

        [Column(TypeName = "text")]
        public string recipe_description { get; set; }

        [Column(TypeName = "text")]
        public string recipe_instructions { get; set; }
    }
}
