using ApplicationTp2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ApplicationTp2.Controllers
{
    public class MovieController : Controller

    {
        public readonly ApplicationDbContext _db;
        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            var listmovies = _db.Movies.ToList();
            return View(listmovies);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Movie m)
        {

            if (ModelState.IsValid)
            {
                _db.Movies.Add(m);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(m);

        }
		public IActionResult Edit(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}

			var objToEdit = _db.Movies.Find(id);
			if (objToEdit == null)
			{
				return NotFound();
			}

			return View(objToEdit);
		}
        [HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Movie m)
        {
            if (ModelState.IsValid)
            {
				_db.Movies.Update(m);
				_db.SaveChanges();
                return RedirectToAction("Index");
			}
            return View(m);
            
           
        }
		public IActionResult Delete(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}

			var objToEdit = _db.Movies.Find(id);
			if (objToEdit == null)
			{
				return NotFound();
			}

			return View(objToEdit);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Delete(Movie m)
		{
			if (ModelState.IsValid)
			{
				_db.Movies.Remove(m);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(m);


		}

	}
}
