using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourProject.Model
{
    public class Tourist
    {
        public Tourist()
        {
            TouristGuidePlaces = new HashSet<TouristGuidePlace>();           
            Countries = new HashSet<Country>();
        }
        public int TouristID { get; set; }
        public int NationalityID { get; set; }
        public int GenderID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        
        public Nationality Nationality { get; set; }
        


        
        public ICollection<TouristGuidePlace> TouristGuidePlaces { get; set; }
        public ICollection<Country> Countries { get; set; }

    }
}
