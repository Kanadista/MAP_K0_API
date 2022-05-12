using MAP_K0_DAL.Handlers;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAP_K0_BL.Handlers
{
    public class clsEventAssistanceHandlerBL
    {
        
        public clsEventAssistance getEventAssistanceById(int idEvent, int idUser)
        {
            clsEventAssistanceHandlerDAL oHandler = new clsEventAssistanceHandlerDAL();
            return oHandler.getEventAssistanceById(idEvent, idUser);

        }

        public int deleteEventAssistance(int idEvent, int idUser)
        {
            clsEventAssistanceHandlerDAL oHandler = new clsEventAssistanceHandlerDAL();
            return oHandler.deleteEventAssistance(idEvent, idUser);
        }

        public int updateEventAssistance(clsEventAssistance eventAssistance)
        {
            clsEventAssistanceHandlerDAL oHandler = new clsEventAssistanceHandlerDAL();
            return oHandler.updateEventAssistance(eventAssistance);
        }

        public int createEventAssistance(clsEventAssistance eventAssistance)
        {
            clsEventAssistanceHandlerDAL oHandler = new clsEventAssistanceHandlerDAL();
            return oHandler.createEventAssistance(eventAssistance);
        }

    }
}
