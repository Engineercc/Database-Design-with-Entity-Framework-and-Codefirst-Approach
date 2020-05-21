using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourProject.Model;

namespace TourProject.Mapping
{
    class GuideMapping : EntityTypeConfiguration<Guide>
    {
        public GuideMapping()
        {
            HasKey(x => x.GuideID);

            Property(x => x.FirstName)
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.LastName)
                .HasMaxLength(30)
                .IsRequired();

            Property(x => x.Phone)
                .HasMaxLength(11)
                .IsRequired();

            HasMany(x => x.TouristGuidePlaces)
                .WithRequired(x => x.Guide)
                .HasForeignKey(x => x.GuideID);
        }
    }
}
