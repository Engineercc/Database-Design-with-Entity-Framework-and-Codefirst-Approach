using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourProject.Model;

namespace TourProject.Mapping
{
    class VisitedPlaceMapping : EntityTypeConfiguration<VisitedPlace>
    {
        public VisitedPlaceMapping()
        {
            HasKey(x => x.PlaceID);

            Property(x => x.PlaceName)
                .HasMaxLength(130)
                .IsRequired();

            HasMany(x => x.TouristGuidePlaces)
                .WithRequired(x => x.VisitedPlace)
                .HasForeignKey(x => x.PlaceID);
        }
    }
}
