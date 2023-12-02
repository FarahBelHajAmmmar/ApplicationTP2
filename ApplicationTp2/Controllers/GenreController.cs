using ApplicationTp2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTp2.Controllers
{
    public class GenreController : Controller
    {

        public readonly ApplicationDbContext _db;
        public GenreController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
