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
    public class UserRatingLocationController : ApiController
    {
        // GET: api/UserRatingLocation
        public IEnumerable<clsUserRatingLocation> Get()
        {

            clsUserRatingLocationListBL userRatingLocationList = new clsUserRatingLocationListBL();
            List<clsUserRatingLocation> list = new List<clsUserRatingLocation>();

            try
            {
                list = userRatingLocationList.getListBL();

            }

            catch (Exception e)
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

            return list;
        }

        // GET: api/UserRatingLocation/5
        public clsUserRatingLocation Get(int idLocation)
        {
            clsUserRatingLocationHandlerBL oHandler = new clsUserRatingLocationHandlerBL();
            clsUserRatingLocation oUserRatingLocation;

            try
            {

                oUserRatingLocation = oHandler.getUserRatingLocationById(idLocation);

            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

            return oUserRatingLocation;
        }

        // POST: api/UserRatingLocation
        [HttpPost]
        public void Post([FromBody] clsUserRatingLocation oUserRatingLocation)
        {
            clsUserRatingLocationHandlerBL oHandler = new clsUserRatingLocationHandlerBL();

            try
            {

                oHandler.createUserRatingLocation(oUserRatingLocation);
            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

        }

        // PUT: api/UserRatingLocation/5
        [Route("api/UserRatingLocation/{idLocation}")]
        [HttpPut]
        public void Put(int idLocation, [FromBody] clsUserRatingLocation oUserRatingLocation)
        {
            clsUserRatingLocationHandlerBL oHandler = new clsUserRatingLocationHandlerBL();

            oUserRatingLocation.idLocation = idLocation;

            try
            {

                oHandler.updateUserRatingLocation(oUserRatingLocation);

            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }


        }

        // DELETE: api/UserRatingLocation/5
        [HttpDelete]
        public void Delete(string idUser, int idLocation)
        {

            clsUserRatingLocationHandlerBL oHandler = new clsUserRatingLocationHandlerBL();

            try
            {

                oHandler.deleteUserRatingLocation(idUser, idLocation);
            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }

        }

    }
}