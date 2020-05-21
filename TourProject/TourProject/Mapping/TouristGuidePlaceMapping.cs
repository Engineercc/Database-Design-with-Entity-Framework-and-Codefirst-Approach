using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourProject.Model;

namespace TourProject.Mapping
{
    class TouristGuidePlaceMapping : EntityTypeConfiguration<TouristGuidePlace>
    {
        public TouristGuidePlaceMapping()
        {
            HasKey(x => new { x.TouristID, x.PlaceID, x.GuideID});

            Property(a => a.ArrivalDate)
                .IsRequired();

        }
    }
}
