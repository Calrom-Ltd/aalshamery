using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAPIapplication.Model;
using WebApplication1.Helper;

namespace WebApplication1.Controllers
{
    public class studentController : Controller
    {
        studentAPI _API = new studentAPI();
        public async Task<IActionResult> Index()
        {
            List<Student> students = new List<Student>();
            HttpClient client = _API.initial();
            HttpResponseMessage res = await client.GetAsync("api/student");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                students = JsonConvert.DeserializeObject<List<Student>>(result);
            }
            return View(students);
        }
    }
}