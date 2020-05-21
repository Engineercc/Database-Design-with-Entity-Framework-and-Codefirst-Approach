using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourProject.Model;

namespace TourProject.Mapping
{
    class CountryMapping : EntityTypeConfiguration<Country>
    {
        public CountryMapping()
        {
            HasKey(x => x.CountryID);

            Property(x => x.CountryName)
                .HasMaxLength(50)
                .IsRequired();

            HasMany(x => x.Tourists)
                .WithMany( x => x.Countries)
                .Map(a =>
                {
                    a.ToTable("TouristCountryDetail");
                    a.MapLeftKey("CountryID");
                    a.MapRightKey("TouristID");
                });
        }
    }
}
