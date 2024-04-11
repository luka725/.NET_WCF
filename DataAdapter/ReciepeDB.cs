using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAdapter
{
    public partial class ReciepeDB : DbContext
    {
        public ReciepeDB()
            : base("name=ReciepeDB")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Recipe_Ingredient> Recipe_Ingredient { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>()
                .Property(e => e.ingredient_name)
                .IsUnicode(false);

            modelBuilder.Entity<Ingredient>()
                .Property(e => e.unit_of_measurement)
                .IsUnicode(false);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.recipe_name)
                .IsUnicode(false);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.recipe_description)
                .IsUnicode(false);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.recipe_instructions)
                .IsUnicode(false);
        }
    }
}
