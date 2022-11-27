namespace DummyBazarEmirhan2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DummyBazarEmirhan2.Models.DummyBazarModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DummyBazarEmirhan2.Models.DummyBazarModel context)
        {
            context.ManagersType.AddOrUpdate(m => m.ID, new Models.ManagerType() { ID = 1, Name = "Admin" });
            context.ManagersType.AddOrUpdate(m => m.ID, new Models.ManagerType() { ID = 2, Name = "Moderetör" });
            context.Managers.AddOrUpdate(m => m.ID, new Models.Manager() { ID = 1, Name = "Emirhan",Surname="topuz",Mail="emirhan2809@gmail.com",ManagerType_ID=1,Password="123456789",
                UserName="e.topuz",IsActive=true});

        }
    }
}
