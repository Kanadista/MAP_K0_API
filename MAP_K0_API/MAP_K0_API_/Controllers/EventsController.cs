﻿using MAP_K0_BL.Handlers;
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
        public class EventsController : ApiController
        {
            // GET: api/Events
            public IEnumerable<clsEvent> Get()
            {

                clsEventListBL eventList = new clsEventListBL();
                List<clsEvent> list = new List<clsEvent>();
             
                try
                {
                    list = eventList.getListBL();

                }

                catch (Exception e)
                {
                    throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

                }

                return list;
            }

            // GET: api/Events/5
            public clsEvent Get(int id)
            {
            clsEventsHandlerBL oHandler = new clsEventsHandlerBL();
            clsEvent oEvent;

                try
                {

                oEvent = oHandler.getEventById(id);

                }

                catch (Exception e)
                {

                    throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

                }

                return oEvent;
            }

            // POST: api/Events
            public IHttpActionResult Post([FromBody] clsEvent oEvent)
            {
            clsEventsHandlerBL oHandler = new clsEventsHandlerBL();
            IHttpActionResult result;
            int rowsAffected;

            try
                {

                rowsAffected = oHandler.createEvent(oEvent);
                if (rowsAffected == 0)
                {
                    result = NotFound();
                }
                else
                {
                    result = Ok();
                }
            }

                catch (Exception e)
                {

                    throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

                }

            return result;
            }

            // PUT: api/Events/5
            public void Put(int id, [FromBody] clsEvent oEvent)
            {
                     clsEventsHandlerBL oHandler = new clsEventsHandlerBL();

                     oEvent.id = id;

                try
                {

                    oHandler.updateEvent(oEvent);

                }

                catch (Exception e)
                {

                    throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

                }


            }

            // DELETE: api/Events/5
            public void Delete(int id)
            {

             clsEventsHandlerBL oHandler = new clsEventsHandlerBL();

            try
                {

                    oHandler.deleteEvent(id);
                }

                catch (Exception e)
                {

                    throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
                }

            }
        }

    }