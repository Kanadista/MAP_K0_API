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
        clsUserSavedLocationListDAL listDal = new clsUserSavedLocationListDAL();
        public List<clsUserSavedLocations> getListBL(String idUser)
        {
            return listDal.getList(idUser);
        }
    }
}
