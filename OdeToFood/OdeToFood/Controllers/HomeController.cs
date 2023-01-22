using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OdeToFood.Data;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
	public class HomeController : Controller
	{
		private readonly ApplicationDbContext _db;

		public HomeController(ApplicationDbContext dbContext)
		{
			_db = dbContext;
		}

		public IActionResult Index()
		{
            var model = from r in _db.Restaurants
                        orderby r.Reviews.Average(review => review.Rating)
                        select new RestaurantListViewModel
                        {
                            Id = r.Id,
                            Name = r.Name,
                            City = r.City,
                            Country = r.Country,
                            CountOfReviews = r.Reviews.Count()


            return View(model);
		}

		public IActionResult Privacy()
		{
			return View();
		}
		public IActionResult About()
		{
			var model = new AboutModel();
			model.Name = "Kristjan";
			model.Location = "Tallinn, Estonia";
			return View(model);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		protected override void Dispose(bool disposing)
		{
			if (_db != null)
			{
				_db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}