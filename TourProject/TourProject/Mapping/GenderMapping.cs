using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourProject.Model;

namespace TourProject.Mapping
{
    class GenderMapping : EntityTypeConfiguration<Gender>
    {
        public GenderMapping()
        {
            HasKey(x => x.GenderID);

            Property(x => x.GenderDescription)
                .HasMaxLength(15)
                .IsRequired();

            HasMany(x => x.Tourists)
                .WithRequired(x => x.Gender)
                .HasForeignKey( x => x.GenderID);
        }
    }
}
