using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TourProject.Model

{
    public class TouristGuidePlace
    {
       
        public int TouristID { get; set; }
        public int GuideID { get; set; }
        public int PlaceID { get; set; }
        

        public Tourist Tourist { get; set; }
        public Guide Guide { get; set; }
        public VisitedPlace VisitedPlace { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}
