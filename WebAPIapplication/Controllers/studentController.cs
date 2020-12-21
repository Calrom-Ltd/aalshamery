using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIapplication.Model;

namespace WebAPIapplication.Controllers
{
    //[Route("api/[Controller]")]
    [ApiController]
    [Route("[controller]")]
    public class studentController : Controller
    {

        private StudentContext _context;
        public studentController(StudentContext context)
        {
            _context = context;
        }
        [HttpGet("Studentsss")]
        public List<Student> GetStudents()
        {
           return  _context.students.ToList();
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}