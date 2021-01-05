using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIapplication.Model;

namespace WebAPIapplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class loginController : Controller
    {

        private dbAPITestContext _context;
        public loginController(dbAPITestContext context)
        {
            _context = context;
        }
        [HttpPost("UserName & Password")]
        public IActionResult User_Name(string username, string password)
        {
            TblLogin tblLogin = new TblLogin();
            CheckInfo info = new CheckInfo();
            tblLogin.UserName = username;
            tblLogin.Password = password;
            var login = _context.TblLogins.SingleOrDefault(x => x.UserName == tblLogin.UserName && x.Password == tblLogin.Password);
            
            if (login != null)
            {
                return Ok("You have entered successfully");
            }
            else
            {
                return BadRequest("Invalid username or password");
            }
        }

        [HttpGet("ID")]
        public IActionResult Get_messages(int id)
        {
            var User_messages = _context.tbl_User_Massages.SingleOrDefault(x => x.User_id == id);
            if (User_messages!= null)
            {
                CheckInfo checkInformation = new CheckInfo();
                checkInformation.DateOfBirth = User_messages.DateOfBirth;
                checkInformation.Subject = User_messages.Subject;
                checkInformation.Messages = User_messages.Messages;

                return Ok(checkInformation);
            }
            else
            {
                return BadRequest("invalid UserID");
            }
            
        }
    }
}