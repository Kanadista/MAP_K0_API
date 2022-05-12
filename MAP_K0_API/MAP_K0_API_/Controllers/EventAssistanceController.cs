using MAP_K0_BL.Handlers;
using MAP_K0_BL.Lists;
using MAP_K0_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace MAP_K0_API_.Controllers
{
    public class EventAssistanceController : ApiController
    {
        // GET: api/EventsAssistance
        public IEnumerable<clsEventAssistance> Get()
        {

            clsEventAssistanceListBL eventAssistanceList = new clsEventAssistanceListBL();
            List<clsEventAssistance> list = new List<clsEventAssistance>();

            try
            {
                list = eventAssistanceList.getListBL();

            }

            catch (Exception e)
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

            return list;
        }

        // GET: api/EventsAssistance/5
        public clsEventAssistance Get(int idEvent, int idUser)
        {
            clsEventAssistanceHandlerBL oHandler = new clsEventAssistanceHandlerBL();
            clsEventAssistance oEvent;

            try
            {

                oEvent = oHandler.getEventAssistanceById(idEvent, idUser);

            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

            return oEvent;
        }

        // POST: api/EventsAssistance
        public void Post([FromBody] clsEventAssistance oEventAssistance)
        {
            clsEventAssistanceHandlerBL oHandler = new clsEventAssistanceHandlerBL();

            try
            {

                oHandler.createEventAssistance(oEventAssistance);
            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

        }

        // PUT: api/EventsAssistance/5
        public void Put(int idEvent, [FromBody] clsEventAssistance oEventAssistance)
        {
            clsEventAssistanceHandlerBL oHandler = new clsEventAssistanceHandlerBL();

            oEventAssistance.idEvent = idEvent;

            try
            {

                oHandler.updateEventAssistance(oEventAssistance);

            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }


        }

        // DELETE: api/EventsAssistance/5
        public void Delete(int idEvent, int idUser)
        {

            clsEventAssistanceHandlerBL oHandler = new clsEventAssistanceHandlerBL();

            try
            {

                oHandler.deleteEventAssistance(idEvent, idUser);
            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }

        }

    }
}