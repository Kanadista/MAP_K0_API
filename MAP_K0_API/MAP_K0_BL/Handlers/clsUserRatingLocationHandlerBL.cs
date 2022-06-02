using MAP_K0_DAL.Handlers;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Handlers
{
    public class clsUserRatingLocationHandlerBL
    {
        public clsUserRatingLocation getUserRatingLocationById(int idLocation)
        {
            clsUserRatingLocationHandlerDAL oHandler = new clsUserRatingLocationHandlerDAL();
            return oHandler.getUserRatingById(idLocation);

        }

        public int deleteUserRatingLocation(string idUser, int idLocation)
        {
            clsUserRatingLocationHandlerDAL oHandler = new clsUserRatingLocationHandlerDAL();
            return oHandler.deleteUserRatingLocation(idUser, idLocation);

         }

        public int updateUserRatingLocation(clsUserRatingLocation user)
        {
                clsUserRatingLocationHandlerDAL oHandler = new clsUserRatingLocationHandlerDAL();
                return oHandler.updateUserRatingLocation(user);
        }

        public int createUserRatingLocation(clsUserRatingLocation user)
            {
                clsUserRatingLocationHandlerDAL oHandler = new clsUserRatingLocationHandlerDAL();
                return oHandler.createUserRatingLocation(user);
            }
        }
}
