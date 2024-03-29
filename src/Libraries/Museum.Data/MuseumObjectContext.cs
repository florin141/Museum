﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Data.Mapping;

namespace Museum.Data
{
    public class MuseumObjectContext : DbContext
    {
        public MuseumObjectContext()
            : base("Development")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MuseumObjectContext>());

            //Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new MuseumsMap());
            modelBuilder.Configurations.Add(new FeatureMap());
            modelBuilder.Configurations.Add(new MuseumTypeMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
