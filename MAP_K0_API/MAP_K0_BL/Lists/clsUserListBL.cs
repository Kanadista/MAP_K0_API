using MAP_K0_DAL.Lists;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Lists
{
    public class clsUserListBL
    {
        public List<clsUser> eventList = new List<clsUser>();

        clsUserListDAL listDAL = new clsUserListDAL();

        public void setListBL()
        {
            this.eventList = listDAL.getListDAL();
        }

        public List<clsUser> getListBL()
        {
            return this.eventList;
        }

        public clsUserListBL()
        {
            setListBL();
        }
    }
}
