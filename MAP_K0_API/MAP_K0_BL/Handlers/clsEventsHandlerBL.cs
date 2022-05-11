using MAP_K0_DAL.Handlers;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Handlers
{
   public class clsEventsHandlerBL
    {
        public clsEvent getEventAssistanceById(int id)
        {
            clsEventHandlerDAL oHandler = new clsEventHandlerDAL();
            return oHandler.getEventById(id);

        }

        public int deleteEventAssistance(int id)
        {
            clsEventHandlerDAL oHandler = new clsEventHandlerDAL();
            return oHandler.deleteEvent(id);
        }

        public int updateEventAssistance(clsEvent oEvent)
        {
            clsEventHandlerDAL oHandler = new clsEventHandlerDAL();
            return oHandler.updateEvent(oEvent);
        }

        public int createEventAssistance(clsEvent oEvent)
        {
            clsEventHandlerDAL oHandler = new clsEventHandlerDAL();
            return oHandler.createEvent(oEvent);
        }

    }
}
