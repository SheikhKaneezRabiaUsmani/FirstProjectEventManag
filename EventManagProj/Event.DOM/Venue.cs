using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.DOM
{
    public class Venue
    {
        [Display(Name = "ID")]
        public int VenueID { get; set; }

        [Display(Name = "Venue Name")]
        public string VenueName { get; set; }
        public string VenueFilename { get; set; }
        public string VenueFilePath { get; set; }
        public Nullable<int> Createdby { get; set; }
        public Nullable<System.DateTime> Createdate { get; set; }

        [Display(Name = "Venue Price")]
        public Nullable<int> VenueCost { get; set; }

    }
}
