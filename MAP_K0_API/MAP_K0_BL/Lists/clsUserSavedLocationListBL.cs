using MAP_K0_DAL.Lists;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Lists
{
   public class clsUserSavedLocationListBL
    {
        public List<clsUserSavedLocations> clsUserSavedLocationList = new List<clsUserSavedLocations>();

        clsUserSavedLocationListDAL listDAL = new clsUserSavedLocationListDAL();

        public void setListBL()
        {
            this.clsUserSavedLocationList = listDAL.getListDAL();
        }

        public List<clsUserSavedLocations> getListBL()
        {
            return this.clsUserSavedLocationList;
        }

        public clsUserSavedLocationListBL()
        {
            setListBL();
        }
    }
}
