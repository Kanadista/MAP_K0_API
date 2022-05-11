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

        public void setListBL()
        {
            this.clsUserRatingLocationList = listDAL.getListDAL();
        }

        public List<clsUserRatingLocation> getListBL()
        {
            return this.clsUserRatingLocationList;
        }

        public clsUserRatingLocationListBL()
        {
            setListBL();
        }
    }
}
