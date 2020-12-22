using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPIapplication.Model
{
    public partial class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Course { get; set; }
        public string University { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
