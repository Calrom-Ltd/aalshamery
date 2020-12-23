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
        [HttpPost("Enter_UserName_Password")]
        public void User_Name(string username, string password)
        {
            TblLogin tblLogin = new TblLogin();
            tblLogin.UserName = username;
            tblLogin.Password = password;
            var login = _context.TblLogins.SingleOrDefault(x => x.UserName == tblLogin.UserName && x.Password == tblLogin.Password);
            if (login != null)
            {
                CheckInfo.Message = login.Messages;
            }
            else
            {
                CheckInfo.Message = "Invalid UserName Or Password";
            }
                
            //var user_name = _context.TblLogins.SingleOrDefault(x => x.UserName == username);
            //var pass_word = _context.TblLogins.SingleOrDefault(x => x.Password == password);
            //if (user_name != null && pass_word !=null )
            //{
            //    CheckInfo.U = user_name.ToString();
            //    CheckInfo.P = pass_word.ToString();

            //    //TblLogin tblLogin = new TblLogin();
            //    //tblLogin.UserName = username;

            //}

        }
        
        [HttpGet("Messages")]
        public string Get_messages()
        {
            return (CheckInfo.Message); 
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}