using System;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Matrix" };

            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;
            return View(movie);

            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model
            //return View(movie);
            //return new ViewResult();
            //return HttpContext("Hello World");
            //return HttpNotFound();        => //return 404 page error result
            //return new EmptyResult();     => //return empty page
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        public ActionResult Index(int? pageindex, string sortBy)
        {
            if (!pageindex.HasValue)
                pageindex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex = {0} & sortBy = {1}", pageindex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + " / " + month);
        }
    }
}