using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourProject.Model
{
    public class Gender 
    {
        public Gender()
        {
            Tourists = new HashSet<Tourist>();
        }
        public int GenderID { get; set; }
        public string GenderDescription { get; set; }

        public ICollection<Tourist> Tourists { get; set; }
    }
}
