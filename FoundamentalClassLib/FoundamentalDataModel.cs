using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FoundamentalClassLib
{
    public partial class FoundamentalDataModel : DbContext
    {
        public FoundamentalDataModel()
            : base("name=FoundamentalDataModel")
        {
        }

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
