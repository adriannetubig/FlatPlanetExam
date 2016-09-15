using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FlatPlanetExam.Models;

namespace FlatPlanetExam
{
    public class Context : DbContext
    {
        public Context() : base("FlatPlanetTest")
        {
            if (Database.Exists())
            {
                //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Migrations.Configuration>());
            }
            else
            {
                Database.SetInitializer(new FlatPlanetExamDBInitializer());
            }
        }


        public class FlatPlanetExamDBInitializer : CreateDatabaseIfNotExists<Context>
        {
            public FlatPlanetExamDBInitializer()
            {
            }
        }

        public DbSet<CounterModel> CounterModel { get; set; }
    }
}