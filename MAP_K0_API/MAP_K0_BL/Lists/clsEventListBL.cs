using MAP_K0_DAL.Lists;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Lists
{
   public class clsEventListBL
    {
            public List<clsEvent> eventList = new List<clsEvent>();

            clsEventListDAL listDAL = new clsEventListDAL();

            public void setListBL()
            {
                this.eventList = listDAL.getListDAL();
            }

            public List<clsEvent> getListBL()
            {
                return this.eventList;
            }

            public clsEventListBL()
            {
                setListBL();
            }

        }
    }

