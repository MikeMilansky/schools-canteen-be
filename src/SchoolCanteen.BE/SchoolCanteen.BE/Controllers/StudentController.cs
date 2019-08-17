using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolCanteen.BE.Data.Entities;
using SchoolCanteen.BE.Data.Services;

namespace SchoolCanteen.BE.Controllers
{
    [RoutePrefix("api/v1/students")]
    public class StudentController : ApiController
    {
        private StudentService _studentService = new StudentService();
        // GET: api/Student
        [Route("getAll")]
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            var students = _studentService.GetAll();
            
            return students;
        }

        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }
    }
}
