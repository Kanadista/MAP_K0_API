using MAP_K0_DAL.Handlers;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Handlers
{
   public class clsUserHandlerBL
    {
        public clsUser getUserById(int id)
        {
            clsUserHandlerDAL oHandler = new clsUserHandlerDAL();
            return oHandler.getUserById(id);

        }

        public int deleteEventAssistance(int id)
        {
            clsUserHandlerDAL oHandler = new clsUserHandlerDAL();
            return oHandler.deleteUser(id);
        }

        public int updateLocationAssistance(clsUser user)
        {
            clsUserHandlerDAL oHandler = new clsUserHandlerDAL();
            return oHandler.updateUser(user);
        }

        public int createEventAssistance(clsUser user)
        {
            clsUserHandlerDAL oHandler = new clsUserHandlerDAL();
            return oHandler.createUser(user);
        }
    }
}
