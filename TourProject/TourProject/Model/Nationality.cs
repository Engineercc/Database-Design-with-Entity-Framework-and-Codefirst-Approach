using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourProject.Model
{
    public class Nationality
    {
        public int NationalityID { get; set; }
        public string NationalityDescription { get; set; }

        public ICollection<Tourist> Tourists { get; set; }
    }
}
