using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourProject.Model
{
    public class Guide
    {
        public Guide()
        {
            TouristGuidePlaces = new HashSet<TouristGuidePlace>();
        }
        public int GuideID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public ICollection<TouristGuidePlace> TouristGuidePlaces { get; set; }
    }
}
