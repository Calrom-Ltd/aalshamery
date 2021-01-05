using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIapplication.Model
{
    public partial class tbl_User_Massage
    {
        public int id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Subject { get; set; }
        public string Messages { get; set; }
        public int User_id { get; set; }
    }
}
