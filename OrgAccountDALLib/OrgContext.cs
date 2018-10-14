using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OrgAccount.Domain;

namespace OrgAccountDALLib
{
    public class OrgContext : DbContext
    {
        public DbSet<OrgReport> reports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");            
        }
    }
}
