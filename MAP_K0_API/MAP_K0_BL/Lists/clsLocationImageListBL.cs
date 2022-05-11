using MAP_K0_DAL.Lists;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Lists
{
    public class clsLocationImageListBL
    {
        public List<clsLocationImage> locationImageList = new List<clsLocationImage>();

        clsLocationImageListDAL listDAL = new clsLocationImageListDAL();

        public void setListBL()
        {
            this.locationImageList = listDAL.getListDAL();
        }

        public List<clsLocationImage> getListBL()
        {
            return this.locationImageList;
        }

        public clsLocationImageListBL()
        {
            setListBL();
        }
    }
}
