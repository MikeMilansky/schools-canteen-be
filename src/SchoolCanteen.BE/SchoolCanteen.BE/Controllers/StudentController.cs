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

        [HttpGet]
        [Route("getAll")]
        public IEnumerable<Student> Get()
        {
            var students = _studentService.GetAll();
            
            return students;
        }

        [HttpGet]
        [Route("{id}")]
        public Student Get(int id)
        {
            var students = _studentService.GetAll();
            return students.FirstOrDefault(x => x.Id == id);
        }
    }
}
