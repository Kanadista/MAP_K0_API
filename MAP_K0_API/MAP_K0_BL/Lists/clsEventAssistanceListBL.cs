using MAP_K0_DAL.Lists;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Lists
{
    public class clsEventAssistanceListBL
    {
        public List<clsEventAssistance> eventAssistanceList = new List<clsEventAssistance>();

        clsEventAssistanceListDAL listDAL = new clsEventAssistanceListDAL();

        public void setListBL()
        {
            this.eventAssistanceList = listDAL.getListDAL();
        }

        public List<clsEventAssistance> getListBL()
        {
            return this.eventAssistanceList;
        }

        public clsEventAssistanceListBL()
        {
            setListBL();
        }

    }
}
