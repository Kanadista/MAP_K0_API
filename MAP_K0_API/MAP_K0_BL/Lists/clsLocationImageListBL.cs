using MAP_K0_DAL.Lists;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Lists
{
    public class clsLocationImageListBL
    {
        
        clsLocationImageListDAL listDAL = new clsLocationImageListDAL();

        public List<clsLocationImage> getListBL(int id)
        {
            return listDAL.getList(id);
        }

    }
}
