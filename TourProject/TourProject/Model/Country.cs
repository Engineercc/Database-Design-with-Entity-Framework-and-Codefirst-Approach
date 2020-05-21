using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourProject.Model
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public ICollection<Tourist> Tourists { get; set; }
    }
}
