using DemoAngularWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAngularWebAPI.Controllers
{
    public class UserController : ApiController
    {
        [HttpPost]
        public IHttpActionResult authenticate(string UserName, string Password)
        {
            APIResponse objAPIResponse = new APIResponse();
            try
            {
                User objUser = new User();
                objUser.TOKEN = "BEARER ABTEST TOKEN";

                objAPIResponse.STATUS = ResponseStatus.SUCCESS;
                objAPIResponse.DATA = objUser;
            }
            catch (Exception ex)
            {
                objAPIResponse.STATUS = ResponseStatus.SUCCESS;
                objAPIResponse.ERROR = new List<ERRORS> { new ERRORS { CODE = "ERR", MESSAGE = ex.Message, DESCIPTION = ex.StackTrace } };
            }

            return Ok(objAPIResponse);
        }

        [HttpPost]
        public IHttpActionResult CheckPageAccess(string Role, string Route)
        {
            APIResponse objAPIResponse = new APIResponse();
            try
            {

            }
            catch (Exception ex)
            {
                objAPIResponse.STATUS = ResponseStatus.SUCCESS;
                objAPIResponse.ERROR = new List<ERRORS> { new ERRORS { CODE = "ERR", MESSAGE = ex.Message, DESCIPTION = ex.StackTrace } };
            }
            return Ok(objAPIResponse);
        }


    }
}
