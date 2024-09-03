using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace CodeFirstEmployee.Models
{
    public partial class appDBcontex : DbContext
    {
        public appDBcontex() :base("appDBcontex")
        { 
        
        
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Employee>Employees { get; set; }   
        public virtual DbSet<QualificationEntry> QualificationEntries { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }


    }
}