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
        [HttpPost("login")]
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

        [HttpGet("getmessages")]
        public IActionResult Get_messages(int id)
        {
            var Usermessages = _context.tbl_User_Massages.SingleOrDefault(x => x.User_id == id);
            if (Usermessages != null)
            {
                CheckInfo checkInformation = new CheckInfo();
                checkInformation.DateOfBirth = Usermessages.DateOfBirth;
                checkInformation.Subject = Usermessages.Subject;
                checkInformation.Messages = Usermessages.Messages;

                return Ok(checkInformation);
            }
            else
            {
                return BadRequest("invalid UserID");
            }
            
        }
    }
}