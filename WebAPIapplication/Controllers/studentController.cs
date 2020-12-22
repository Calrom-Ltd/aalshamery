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

        private dbAPITestContext _context;
        public studentController(dbAPITestContext context)
        {
            _context = context;
        }
        //[HttpGet("Studentsss")]
        //public List<Student> GetStudents()
        //{
        //   return  _context.Students.ToList();
        //}
        [HttpPost("Enter UserName")]
        public void User_Name(string username)
        {
            var user_name = _context.TblLogins.SingleOrDefault(x => x.UserName == username);
            if (user_name == null)
            {
                CheckInfo.U = null;
            }
            else
            {
                CheckInfo.U = username;
            }
        }
        [HttpPost("Enter Password")]
        public void Password(string password)
        {
            var pass_word = _context.TblLogins.SingleOrDefault(x => x.Password == password);
            if (pass_word == null)
            {
                CheckInfo.P = null;
            }
            else
            {
                CheckInfo.P = password;
            }
        }
        [HttpGet("Messages")]
        public IActionResult Get_messages()
        {
            if(CheckInfo.U != null && CheckInfo.P != null)
            {
                var Username = _context.TblLogins.SingleOrDefault(x => x.UserName == CheckInfo.U && x.Password == CheckInfo.P);
                return Ok(Username.Messages);
            }
            else
            {
                return NotFound("Invalid UserName or Password");
            }
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}