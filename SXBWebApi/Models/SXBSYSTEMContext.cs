using SXBModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SXBWebApi.Models
{
    public class SXBSYSTEMContext: DbContext
    {
        public SXBSYSTEMContext() : base("name=SXBSYSTEMContext") { }

        public DbSet<SYS_USER> SysUsers { get; set; }

        public DbSet<USE_PERSON> UsePsersons { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<SYS_USER>().HasOptional(c => c.Address)
            //    .WithOptionalDependent(add => add.Contact);
            //modelBuilder.Entity<USE_PERSON>().HasMany(c => c.Contacts)
            //    .WithRequired(c => c.CGroup).WillCascadeOnDelete(false);
            //modelBuilder.Entity<EasyUIEFWebApp.DAL.EFModels.Contact>().HasOptional(c => c.CGroup)
            //    .WithMany(c => c.Contacts).WillCascadeOnDelete(true);
        }
    }
}