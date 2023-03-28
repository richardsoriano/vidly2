using Microsoft.AspNetCore.Mvc;
using vidly2.Models;
using vidly2.ViewModels;

namespace vidly2.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer {Name = "The Mandelorian" },
                new Customer { Name = "Captain Kirk" }

            };
            var viewModel = new RandomMovieViewModel
          
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
       
        }
        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
       public IActionResult ByReleaseDate(int year, byte month) 
        {
            return Content(year + "/" + month);
        }
    }
}
