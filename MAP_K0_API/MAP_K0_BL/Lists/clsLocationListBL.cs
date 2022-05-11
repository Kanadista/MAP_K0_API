using MAP_K0_DAL.Lists;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Lists
{
    public class clsLocationListBL
    {
        public List<clsLocation> eventList = new List<clsLocation>();

        clsLocationListDAL listDAL = new clsLocationListDAL();

        public void setListBL()
        {
            this.eventList = listDAL.getListDAL();
        }

        public List<clsLocation> getListBL()
        {
            return this.eventList;
        }

        public clsLocationListBL()
        {
            setListBL();
        }
    }
}
