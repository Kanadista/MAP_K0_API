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
    public class UsersController : ApiController
    {
        // GET: api/Users
        public IEnumerable<clsUser> Get()
        {

            clsUserListBL userList = new clsUserListBL();
            List<clsUser> list = new List<clsUser>();

            try
            {
                list = userList.getListBL();

            }

            catch (Exception e)
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

            return list;
        }

        // GET: api/Users/5
        public clsUser Get(int id)
        {
            clsUserHandlerBL oHandler = new clsUserHandlerBL();
            clsUser oUser;

            try
            {

                oUser = oHandler.getUserById(id);

            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

            return oUser;
        }

        // POST: api/Users
        public void Post([FromBody] clsUser oUser)
        {
            clsUserHandlerBL oHandler = new clsUserHandlerBL();

            try
            {

                oHandler.createUser(oUser);
            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }

        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody] clsUser oUser)
        {
            clsUserHandlerBL oHandler = new clsUserHandlerBL();

            oUser.id = id;

            try
            {

                oHandler.updateUser(oUser);

            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);

            }


        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {

            clsUserHandlerBL oHandler = new clsUserHandlerBL();


            try
            {

                oHandler.deleteUser(id);
            }

            catch (Exception e)
            {

                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }

        }
    }
}