using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourProject.Model
{
    public class VisitedPlace
    {
        public VisitedPlace()
        {
            TouristGuidePlaces = new HashSet<TouristGuidePlace>();
        }
        public int PlaceID { get; set; }
        public string PlaceName { get; set; }

        public ICollection<TouristGuidePlace> TouristGuidePlaces { get; set; }

    }
}
