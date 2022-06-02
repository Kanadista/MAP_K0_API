using MAP_K0_DAL.Handlers;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Handlers
{
    public class clsUserSavedLocationsHandlerBL
    {
        public clsUserSavedLocations getUserSavedLocationById(string idUser)
        {
            clsUserSavedLocationHandlerDAL oHandler = new clsUserSavedLocationHandlerDAL();
            return oHandler.getUserSavedLocationById(idUser);

        }

        public int deleteUserSavedLocation(string idUser, int idLocation)
        {
            clsUserSavedLocationHandlerDAL oHandler = new clsUserSavedLocationHandlerDAL();
            return oHandler.deleteUserSavedLocation(idUser, idLocation);

        }

        public int updateUserSavedLocation(clsUserSavedLocations userSavedLocation)
        {
            clsUserSavedLocationHandlerDAL oHandler = new clsUserSavedLocationHandlerDAL();
            return oHandler.updateUserSavedLocation(userSavedLocation);
        }

        public int createUserSavedLocation(clsUserSavedLocations userSavedLocation)
        {
            clsUserSavedLocationHandlerDAL oHandler = new clsUserSavedLocationHandlerDAL();
            return oHandler.createUserSavedLocation(userSavedLocation);
        }

    }
}
