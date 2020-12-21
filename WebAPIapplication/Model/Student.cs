using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIapplication.Model
{
    public class Student
    {
        public int ID { set; get; }
        public string First_Name { set; get; }
        public string Last_Name { set; get; }
        public string Address { set; get; }
        public string Course { set; get; }
        public string University { set; get; }
        public DateTime DateOfBirth { set; get; }

    }
}
