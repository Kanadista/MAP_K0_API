using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_Entities
{
    public class clsUser
    {
        public int id { get; set; }
        public string nickName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public byte[] profilePic { get; set; }
        public int level { get; set; }
        public int levelxp { get; get; }
    }
}
