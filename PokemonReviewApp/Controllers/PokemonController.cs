using Microsoft.AspNetCore.Mvc;

namespace PokemonReviewApp.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
