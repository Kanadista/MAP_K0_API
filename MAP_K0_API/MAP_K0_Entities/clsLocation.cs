using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_Entities
{
    public class clsLocation
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal latitud {get;set;}
        public decimal longitude { get; set; }
        public string creatorId { get; set; }
    }
}
