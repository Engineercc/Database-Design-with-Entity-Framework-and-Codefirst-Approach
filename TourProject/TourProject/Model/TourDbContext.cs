using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourProject.Mapping;

namespace TourProject.Model
{
    class TourDbContext : DbContext
    {
        public TourDbContext()
            :base ("Server = . ; Database = TourProjectDB; Trusted_Connection= True")
        {

        }
        

        public DbSet<TouristGuidePlace> TouristGuidePlaces { get; set; }       
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<VisitedPlace> VisitedPlaces  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountryMapping());
            modelBuilder.Configurations.Add(new GenderMapping());
            modelBuilder.Configurations.Add(new GuideMapping());
            modelBuilder.Configurations.Add(new VisitedPlaceMapping());
            modelBuilder.Configurations.Add(new NationalityMapping());
            modelBuilder.Configurations.Add(new TouristGuidePlaceMapping());
            modelBuilder.Configurations.Add(new TouristMapping());

        }
    }
}
