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
        // GET: api/UserRatingLocation/5
        [Route("api/UserRatingLocation/{idLocation}")]
        [HttpGet]
        public IEnumerable<clsUserRatingLocation> Get(int idLocation)
        {

            clsUserRatingLocationListBL userRatingLocationList = new clsUserRatingLocationListBL();
            List<clsUserRatingLocation> list = new List<clsUserRatingLocation>();

            try
            {
                list = userRatingLocationList.getListBL(idLocation);
            }

            catch (Exception e)
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

            return list;
        }

        // POST: api/UserRatingLocation
        [HttpPost]
        public IHttpActionResult Post([FromBody] clsUserRatingLocation oUserRatingLocation)
        {
            clsUserRatingLocationHandlerBL oHandler = new clsUserRatingLocationHandlerBL();
            IHttpActionResult result;
            int rowsAffected = 0;

            try
            {

                rowsAffected = oHandler.createUserRatingLocation(oUserRatingLocation);

                if(rowsAffected == 0)
                {
                    result = NotFound();
                }
                else
                {
                    result = Ok(rowsAffected);
                }
            }

            catch (Exception e)
            {
         
                result = BadRequest("Bad request");

            }
            return result;
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