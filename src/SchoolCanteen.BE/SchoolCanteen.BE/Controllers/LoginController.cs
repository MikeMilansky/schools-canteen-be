using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolCanteen.BE.Data.Entities;

namespace SchoolCanteen.BE.Controllers
{
    [RoutePrefix("api/v1/login")]
    public class LoginController : ApiController
    {
        [Route("")]
        [HttpPost]
        public IHttpActionResult Login(string login, string password)
        {
            if (login == "Admin")
                return Ok(new
                {
                    User = login,
                    Role = Role.School,
                    Token = "YWxmZGtzamYgc2RmbDtranNkIGxzbGRqZmxza2RqZiANCnNkZnNsZA=="
                });

            return Ok(new
            {
                User = login,
                Role = Role.Parent,
                Token = "DQpUaGlzIGlzIHNvbWUgdGV4dCB0byBjb252ZXJ0IHZpYSBDcnlwdA=="
            });
        }
    }
}
