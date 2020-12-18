using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Demo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class studentsController : ControllerBase
    {
        List<Student> students = new List<Student>()
            {
                new Student (){ ID=1, Name="Atef", Address="55 bramhall street", Country="Yeemn"},
                new Student (){ ID=2, Name="Ali", Address="58 bramhall street", Country="Dubia"},
                new Student (){ ID=3, Name="Zara", Address="77 bramhall street", Country="UAE"},
                new Student (){ ID=4, Name="James", Address="85 bramhall street", Country="Turky"},
            };

        [HttpGet("All student")]
        //[NonAction]
        public IActionResult Gets()
        {
            if (students.Count == 0)
            {
                return NotFound("No list found");
            }
            return Ok(students);
        }
        [HttpGet("Specific student")]
        //[NonAction]
        public IActionResult Get(int id)
        {
            var student = students.SingleOrDefault(x => x.ID == id);
            if (student == null)
            {
                return NotFound("No student inserted");
            }
            return Ok(student);
        }
    }
}