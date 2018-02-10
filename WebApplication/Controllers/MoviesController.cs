using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.Models.ViewModels;


namespace WebApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Random()
        {
            var movies = new List<Movie>
            {
                    new Movie  { movieName= "Shrek"},
                    new Movie  { movieName= "Wall-e"}
            };

            var viewModel = new RandomCustomerViewModel
            {
                Movies = movies
            };


            return View(viewModel);
        }

        [Route("movie/{id:regex(\\d{1})}")]
        public ActionResult Error404()
        {
            HttpNotFoundResult result = new HttpNotFoundResult();

            return HttpNotFound();
        }
    }
}