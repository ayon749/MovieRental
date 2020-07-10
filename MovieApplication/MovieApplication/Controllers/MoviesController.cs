using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }
		[Route("Movies/Release/{MovieId}/{Name}")]
		public ActionResult ByRealese(int MovieId,string Name)
		{
			return Content("Movie " + Name + " And id " + MovieId);
		}

	}
}