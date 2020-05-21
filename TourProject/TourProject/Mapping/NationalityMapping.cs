using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourProject.Model;

namespace TourProject.Mapping
{
    class NationalityMapping : EntityTypeConfiguration<Nationality>
    {
        public NationalityMapping()
        {
            HasKey(x => x.NationalityID);

            Property(x => x.NationalityDescription)
                .HasMaxLength(25);

            HasMany(a => a.Tourists)
                .WithRequired(a => a.Nationality)
                .HasForeignKey(a => a.NationalityID);
        }
    }
}
