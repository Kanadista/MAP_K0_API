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
    public class LocationImagesController : ApiController
    {
        // GET: api/LocationImages
        public IEnumerable<clsLocationImage> Get()
        {

            clsLocationImageListBL locationImageList = new clsLocationImageListBL();
            List<clsLocationImage> list = new List<clsLocationImage>();

            try
            {
                list = locationImageList.getListBL();
            }

            catch (Exception e)
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

            return list;
        }


        // POST: api/LocationImages
        public void Post([FromBody] clsLocationImage oLocationImage)
        {
            clsLocationImageHandlerBL oHandler = new clsLocationImageHandlerBL();

            try
            {

                oHandler.createLocationImage(oLocationImage);
            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

        }

        // PUT: api/LocationImages/5
        public void Put(int idLocation, [FromBody] clsLocationImage oLocationImage)
        {
            clsLocationImageHandlerBL oHandler = new clsLocationImageHandlerBL();

            oLocationImage.idLocation = idLocation;

            try
            {

                oHandler.updateLocationImage(oLocationImage);

            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }


        }

        // DELETE: api/LocationImages/5
        public void Delete(int idLocation, int idUser)
        {

            clsLocationImageHandlerBL oHandler = new clsLocationImageHandlerBL();

            try
            {

                oHandler.deleteLocationImage(idLocation, idUser);
            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }

        }

    }
}