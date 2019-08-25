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
            //return View(movie);
            //return new ViewResult();
            //return HttpContext("Hello World");
            //return HttpNotFound();        => //return 404 page error result
            //return new EmptyResult();     => //return empty page
            return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
        }
    }
}