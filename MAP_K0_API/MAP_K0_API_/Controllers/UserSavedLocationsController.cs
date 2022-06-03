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
        // GET: api/UserSavedLocations
     
        public IEnumerable<clsUserSavedLocations> Get()
        {

            clsUserSavedLocationListBL userSavedLocationList = new clsUserSavedLocationListBL();
            List<clsUserSavedLocations> list = new List<clsUserSavedLocations>();

            try
            {
                list = userSavedLocationList.getListBL();

            }

            catch (Exception e)
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

            return list;
        }

        // GET: api/UserSavedLocations/5
        public clsUserSavedLocations Get(string idUser)
        {
            clsUserSavedLocationsHandlerBL oHandler = new clsUserSavedLocationsHandlerBL();
            clsUserSavedLocations oUserSavedLocation;

            try
            {

                oUserSavedLocation = oHandler.getUserSavedLocationById(idUser);

            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

            return oUserSavedLocation;
        }

        // POST: api/UserSavedLocations
        public void Post([FromBody] clsUserSavedLocations oUserSavedLocation)
        {
            clsUserSavedLocationsHandlerBL oHandler = new clsUserSavedLocationsHandlerBL();

            try
            {

                oHandler.createUserSavedLocation(oUserSavedLocation);
            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

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