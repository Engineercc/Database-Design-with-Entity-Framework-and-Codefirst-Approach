using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourProject.Model;

namespace TourProject.Mapping
{
    class TouristMapping : EntityTypeConfiguration<Tourist>
    {
        public TouristMapping()
        {
            HasKey(x => x.TouristID);

            Property(x => x.FirstName)
                .HasMaxLength(20)               
                .IsRequired();

            Property(x => x.LastName)
                .HasMaxLength(30)
                .IsRequired();

            Property(x => x.BirthDate)
                .IsRequired();

            HasMany(a => a.TouristGuidePlaces)
               .WithRequired(a => a.Tourist)
               .HasForeignKey(a => a.TouristID);
        }
    }
}
