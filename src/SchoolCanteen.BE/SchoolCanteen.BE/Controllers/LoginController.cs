using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolCanteen.BE.Data.Entities;
using SchoolCanteen.BE.Dto;

namespace SchoolCanteen.BE.Controllers
{
    [RoutePrefix("api/v1/login")]
    public class LoginController : ApiController
    {
        [Route("")]
        [HttpPost]
        public IHttpActionResult Login(LoginDto dto)
        {
            if (dto.Login == "Admin")
                return Ok(new
                {
                    User = dto.Login,
                    Role = Role.School,
                    Token = "YWxmZGtzamYgc2RmbDtranNkIGxzbGRqZmxza2RqZiANCnNkZnNsZA=="
                });

            return Ok(new
            {
                User = dto.Login,
                Role = Role.Parent,
                Token = "DQpUaGlzIGlzIHNvbWUgdGV4dCB0byBjb252ZXJ0IHZpYSBDcnlwdA=="
            });
        }
    }
}
