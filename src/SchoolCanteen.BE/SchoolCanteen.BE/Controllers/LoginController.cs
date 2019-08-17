using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolCanteen.BE.Controllers
{
    [RoutePrefix("api/v1/login")]
    public class LoginController : ApiController
    {
        [Route("")]
        [HttpPost]
        public IHttpActionResult Login(string login, string password)
        {
            return Ok(new
            {
                User = login,
                Role = "Parent",
                Token = "VGhpcyBpcyBzb21lIHRleHQgdG8gY29udmVydCB2aWEgQ3J5cHQu"
            });
        }
    }
}
