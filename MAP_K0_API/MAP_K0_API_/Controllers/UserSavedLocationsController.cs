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
        // GET: api/UserRatingLocation
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

        // GET: api/UserRatingLocation/5
        public clsUserSavedLocations Get(int idUser, int idLocation)
        {
            clsUserSavedLocationsHandlerBL oHandler = new clsUserSavedLocationsHandlerBL();
            clsUserSavedLocations oUserSavedLocation;

            try
            {

                oUserSavedLocation = oHandler.getUserSavedLocationById(idUser, idLocation);

            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

            return oUserSavedLocation;
        }

        // POST: api/UserRatingLocation
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

        // PUT: api/UserRatingLocation/5
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

        // DELETE: api/UserRatingLocation/5
        public void Delete(int idUser, int idLocation)
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