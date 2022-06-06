﻿using MAP_K0_DAL.Handlers;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Handlers
{
    public class clsLocationHandlerBL
    {
        public clsLocation getLocationById(int id)
        {
            clsLocationHandlerDAL oHandler = new clsLocationHandlerDAL();
            return oHandler.getLocationById(id);

        }

        public clsLocation getLastLocationByCreatorId(string id)
        {
            clsLocationHandlerDAL oHandler = new clsLocationHandlerDAL();
            return oHandler.getLastLocationByCreatorId(id);
        }

        public int deleteLocation(int id)
        {
            clsLocationHandlerDAL oHandler = new clsLocationHandlerDAL();
            return oHandler.deleteLocation(id);
        }

        public int updateLocation(clsLocation location)
        {
            clsLocationHandlerDAL oHandler = new clsLocationHandlerDAL();
            return oHandler.updateLocation(location);
        }

        public int createLocation(clsLocation location)
        {
            clsLocationHandlerDAL oHandler = new clsLocationHandlerDAL();
            return oHandler.createLocation(location);
        }
    }
}
