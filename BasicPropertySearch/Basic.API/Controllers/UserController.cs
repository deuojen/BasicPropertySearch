using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace Basic.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Authorize]
    public class UserController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult Get()
        {
            var user = User as ClaimsPrincipal;
            var claims = from c in user.Claims
                         select new
                         {
                             type = c.Type,
                             value = c.Value
                         };

            return Json(claims);
        }
    }
}
