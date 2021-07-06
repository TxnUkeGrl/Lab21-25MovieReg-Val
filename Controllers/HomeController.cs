using Lab21MovieRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace Lab21MovieRegistration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieRegistration()
        {
            var model = new Movie();
            model.ListGenre.Add(new SelectListItem("Action/Adventure", "Action/Adventure"));
            model.ListGenre.Add(new SelectListItem("Animated", "Animated"));
            model.ListGenre.Add(new SelectListItem("Children/Family", "Children/Family"));
            model.ListGenre.Add(new SelectListItem("Comedy", "Comedy"));
            model.ListGenre.Add(new SelectListItem("Drama", "Drama"));
            model.ListGenre.Add(new SelectListItem("Fiction/Fantasy", "Fiction/Fantasy"));
            model.ListGenre.Add(new SelectListItem("Horror", "Horror"));
            model.ListGenre.Add(new SelectListItem("Musical", "Musical"));
            model.ListGenre.Add(new SelectListItem("Romance", "Romance"));
            model.ListGenre.Add(new SelectListItem("Western", "Western"));
            model.ListGenre.Add(new SelectListItem("Genre Not Listed", "Genre Not Listed"));
            return View(model);
        }

        public IActionResult Results(Movie userMovie)
        {
            if (ModelState.IsValid)
            {
                return View(userMovie);
            }
            else
            {

                return View("MovieRegistration", userMovie);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
