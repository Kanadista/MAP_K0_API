using MAP_K0_DAL.Handlers;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Handlers
{
   public class clsLocationImageHandlerBL
    {
   
        public int deleteLocationImage(int idLocation, int idImage)
        {
            clsLocationImageHandlerDAL oHandler = new clsLocationImageHandlerDAL();
            return oHandler.deleteLocationImage(idLocation, idImage);
        }

        public int updateLocationImage(clsLocationImage locationImage)
        {
            clsLocationImageHandlerDAL oHandler = new clsLocationImageHandlerDAL();
            return oHandler.updateLocationImage(locationImage);
        }

        public int createLocationImage(clsLocationImage locationImage)
        {
            clsLocationImageHandlerDAL oHandler = new clsLocationImageHandlerDAL();
            return oHandler.createLocationImage(locationImage);
        }
    }
}
