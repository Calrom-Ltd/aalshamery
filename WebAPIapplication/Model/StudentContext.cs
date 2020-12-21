using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIapplication.Model
{
    public class StudentContext :DbContext 
    {
      public StudentContext(DbContextOptions<StudentContext>options) : base(options)
        {

        }
        public DbSet<Student> students { set; get; }
    }
}
