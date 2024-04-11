namespace DataAdapter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ingredient
    {
        [Key]
        [Column(Order = 0)]
        public int ingredient_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(80)]
        public string ingredient_name { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "text")]
        public string unit_of_measurement { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int quantity_available { get; set; }
    }
}
