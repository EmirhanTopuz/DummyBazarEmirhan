using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
