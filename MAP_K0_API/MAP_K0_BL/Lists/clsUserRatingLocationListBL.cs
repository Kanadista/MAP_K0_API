using MAP_K0_DAL.Lists;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Lists
{
    public class clsUserRatingLocationListBL
    {
        public List<clsUserRatingLocation> clsUserRatingLocationList = new List<clsUserRatingLocation>();

        clsUserRatingLocationListDAL listDAL = new clsUserRatingLocationListDAL();

        public List<clsUserRatingLocation> getListBL(int id)
        {
            return listDAL.getListDAL(id);
        }

    }
}
