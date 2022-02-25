using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CoolApi.Models;
using System;

namespace CoolApi.Controllers
{
    [Route("api/[controller]")]

    //Web api
    //https://localhost:5001/api/student
    [ApiController]
    public class StudentController :Controller
    {
        private StudentContext _studentContext;
        public StudentController(StudentContext context)
        {
            _studentContext = context;
        }
        

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAllData()
        {
            return _studentContext.Students.ToList();
           //Console.WriteLine("I am _studentContext "+ _studentContext);
           //List<Student> estudent =  _context.findAllData();
            // Console.WriteLine("I am estudent "+ estudent);
            //return _studentContext.Students.ToList();
        }


        ~StudentController() 
        { 
            _studentContext.Dispose(); 
        }

    }
}