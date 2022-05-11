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
        public class LocationsController : ApiController
        {
            // GET: api/Personas
            public IEnumerable<clsLocation> Get()
            {

                clsLocationListBL locationList = new clsLocationListBL();
                List<clsLocation> list = new List<clsLocation>();

                try
                {
                    list = locationList.getListBL();

                }

                catch (Exception e)
                {
                    throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

                }

                return list;
            }

            // GET: api/Personas/5
            public clsLocation Get(int id)
            {
                clsLocationHandlerBL oHandler = new clsLocationHandlerBL();
                clsLocation oLocation;

                try
                {

                    oLocation = oHandler.getLocationById(id);

                }

                catch (Exception e)
                {

                    throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

                }

                return oLocation;
            }

            // POST: api/Personas
            public void Post([FromBody] clsLocation oLocation)
            {
                clsLocationHandlerBL oHandler = new clsLocationHandlerBL();

                try
                {

                    oHandler.createLocation(oLocation);
                }

                catch (Exception e)
                {

                    throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

                }

            }

            // PUT: api/Personas/5
            public void Put(int id, [FromBody] clsLocation oLocation)
            {
              clsLocationHandlerBL oHandler = new clsLocationHandlerBL();

                oLocation.id = id;

                try
                {

                    oHandler.updateLocation(oLocation);

                }

                catch (Exception e)
                {

                    throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

                }


            }

            // DELETE: api/Personas/5
            public void Delete(int id)
            {

                clsLocationHandlerBL oHandler = new clsLocationHandlerBL();


            try
            {

                    oHandler.deleteLocation(id);
                }

                catch (Exception e)
                {

                    throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
                }

            }
        }
    }