using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web.WebPages;

namespace DummyBazarEmirhan2.Models
{
    public partial class DummyBazarModel : DbContext
    {
        public DummyBazarModel()
            : base("name=DummyBazarModel")
        {

        }

        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<ManagerType> ManagersType { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products {get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         
        }
    }
}
