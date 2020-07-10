using MVCdemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemoApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
   public ActionResult GetStuedent()
		{
			List<Student> students = new List<Student>()
		{
			new Student("Ayan","2015-2-60-021","CSE"),
			new Student("Himu","2015-2-60-031","CSE"),
			new Student("Shimanto","2015-2-60-083","CSE"),
			new Student("Nabid","2015-2-10-083","BBA"),
		};
			
			return View(students);
		}
    }
}