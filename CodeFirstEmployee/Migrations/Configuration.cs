namespace CodeFirstEmployee.Migrations
{
    using CodeFirstEmployee.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstEmployee.Models.appDBcontex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstEmployee.Models.appDBcontex context)
        {
            var Qualifications = new List<Qualification>
             {
                 new Qualification{QualificationId=1, QualifcationName="Msc(Math)"},
                 new Qualification{QualificationId=2, QualifcationName="MA(Bangla)"},
                 new Qualification{QualificationId=3, QualifcationName="MSS(SOCIOLOGY)"},
                  new Qualification{QualificationId=4, QualifcationName="MA(ENGLISH)"},


             };
            Qualifications.ForEach(c => context.Qualifications.AddOrUpdate(c));
            context.SaveChanges();
        }
    }
}
