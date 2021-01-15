namespace WebAPIapplication.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using WebAPIapplication.Model;

    /// <summary>
    /// This class does something.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
        {
        private IDbAPITestContext dbcontext;

        #pragma warning disable SA1614 // Element parameter documentation should have text
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        /// <param name="context"></param>
        public LoginController(IDbAPITestContext context) => this.dbcontext = context;
        #pragma warning restore SA1614 // Element parameter documentation should have text

        #pragma warning disable SA1614 // Element parameter documentation should have text

        #pragma warning disable SA1616 // Element return value documentation should have text
        /// <summary>
        /// this method takes username and password to check them in the database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost("login")]
        #pragma warning restore SA1616 // Element return value documentation should have text
        #pragma warning restore SA1614 // Element parameter documentation should have text
        public IActionResult User_Name(string username, string password)
        {
            var login = this.dbcontext.TblLogins.SingleOrDefault(x => x.UserName == username && x.Password == password);
            if (login != null)
            {
                return this.Ok("You have entered successfully");
            }
            else
            {
                return this.BadRequest("Invalid username or password");
            }
        }

        #pragma warning disable SA1614 // Element parameter documentation should have text
        /// <summary>
        /// this endpoint takes User Id and returns the massages belong to that Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getmessages")]
        #pragma warning restore SA1614 // Element parameter documentation should have text
        public IActionResult Getmessages(int id)
        {
            List<Tbl_User_Massage> usermessages = this.dbcontext.Tbl_User_Massages.Where(x => x.Userid == id).ToList();
            if (usermessages.Count > 0)
            {
                List<CheckInfo> checkInfos = new List<CheckInfo>();
                foreach (var usermassage in usermessages)
                {
                    CheckInfo checkInformation = new CheckInfo();
                    checkInformation.DateOfBirth = usermassage.DateOfBirth;
                    checkInformation.Subject = usermassage.Subject;
                    checkInformation.Messages = usermassage.Messages;
                    checkInfos.Add(checkInformation);
                }

                return this.Ok(checkInfos);
            }
            else
            {
                return this.BadRequest("invalid UserID");
            }
        }
    }
}