﻿ using Microsoft.AspNetCore.Mvc;

namespace PokemonReviewApp.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
