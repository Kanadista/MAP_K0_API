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
    public class UserSavedLocationsController : ApiController
    {
       
        // GET: api/UserSavedLocations/5
        [Route("api/UserSavedLocations/{idUser}")]
        [HttpGet]
        public IEnumerable<clsUserSavedLocations> Get(string idUser)
        {
            clsUserSavedLocationListBL oList = new clsUserSavedLocationListBL();
            List<clsUserSavedLocations> list = new List<clsUserSavedLocations>();

            try
            {

                list = oList.getListBL(idUser);

            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

            return list;
        }

        // POST: api/UserSavedLocations
        [HttpPost]
        public IHttpActionResult Post([FromBody] clsUserSavedLocations oUserSavedLocation)
        {
            clsUserSavedLocationsHandlerBL oHandler = new clsUserSavedLocationsHandlerBL();
            IHttpActionResult result;
            int rowsAffected;

            try
            {

               rowsAffected = oHandler.createUserSavedLocation(oUserSavedLocation);

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

        // PUT: api/UserSavedLocations/5
        public void Put(int idLocation, [FromBody] clsUserSavedLocations oUserSavedLocation)
        {
            clsUserSavedLocationsHandlerBL oHandler = new clsUserSavedLocationsHandlerBL();

            oUserSavedLocation.idLocation = idLocation;

            try
            {

                oHandler.updateUserSavedLocation(oUserSavedLocation);

            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }


        }

        // DELETE: api/UserSavedLocations/5
        public void Delete(string idUser, int idLocation)
        {

            clsUserSavedLocationsHandlerBL oHandler = new clsUserSavedLocationsHandlerBL();

            try
            {

                oHandler.deleteUserSavedLocation(idUser, idLocation);
            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }

        }



    }
}