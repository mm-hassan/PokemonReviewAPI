using Microsoft.AspNetCore.Mvc;

namespace PokemonReviewApp.Controllers
{
    public class OwnerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
