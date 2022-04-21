using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_Entities
{
    public class clsUserRatingLocation
    {
        public int idUser { get; set; }
        public int idLocation { get; set; }
        public int stars { get; set; }
        public string comment { get; set; }
    }
}
