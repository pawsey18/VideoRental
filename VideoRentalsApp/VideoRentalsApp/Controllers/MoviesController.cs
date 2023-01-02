using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentalsApp.Models;
using VideoRentalsApp.ViewModels;

namespace VideoRentalsApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "I know what you did last summer"
            };

            var customers = new List<Customer>
            {

             new Customer
             {
                 Name = "Customer 1"
             },
             new Customer
             {
                 Name = " Customer 2"
             }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}