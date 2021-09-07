using System.Collections.Generic;
using System.Linq;
using BackendWorkshop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BackendWorkshop.Controllers
{
    [Authorize]
    public class MoviesController : Controller
    {
        private readonly MovieDbContext _db;

        public MoviesController(MovieDbContext db)
        {
            _db = db;
        }

        // GET: Movies/Index
        [Authorize]
        public ActionResult Index(string movieGenre, string searchString)
        {
            var genreLst = new List<string>();

            var genreQry = from d in _db.Movies
                orderby d.Genre
                select d.Genre;

            genreLst.AddRange(genreQry.Distinct());
            ViewBag.MovieGenre = new SelectList(genreLst);

            // # homework 3 -- read movies data from local-db,please use linq
            var movies = _db.Movies.ToList();
            
            // # homework 7 -- filter movies data by conditions
            if (movieGenre != null)
            {
                movies = movies.Where(d => d.Genre == movieGenre).ToList();
            }

            if (searchString != null)
            {
                movies = movies.Where(d => d.Title.Contains(searchString)).ToList();
            }

            return View(movies);
        }

        [HttpPost]
        public string Index(FormCollection fc, string searchString)
        {
            return "<h3> From [HttpPost]Index: " + searchString + "</h3>";
        }

        // GET: Movies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult(StatusCodes.Status400BadRequest);
            }

            Movie movie = _db.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        // public ActionResult Create([Bind(Include = "ID,Title,ReleaseDate,Genre,Price,Rating")] Movie movie)
        public ActionResult Create(Movie movie)
        {
            // # homework 5 -- save data to local-db
            _db.Movies.Add(movie);
            _db.SaveChanges();

            return new RedirectResult("/Movies/Index");
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int? id)
        {
            // # homework 8 -- when you on Edit site , you should see the movie info @*
            Movie movie;
            if (id == null)
            {
                return new StatusCodeResult(StatusCodes.Status400BadRequest);
            }
            else
            {
                movie = _db.Movies.FirstOrDefault(d => d.ID == id);
            }

            return View(movie);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        // public ActionResult Edit([Bind(Include = "ID,Title,ReleaseDate,Genre,Price,Rating")] Movie movie)
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(movie).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            // # homework 9 -- find data by id 
            // when id is null ,return HttpStatusCode.BadRequest;
            var movie = _db.Movies.FirstOrDefault(d => d.ID == id);
            if (movie == null)
            {
                return new StatusCodeResult(StatusCodes.Status400BadRequest);
            }
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = _db.Movies.Find(id);
            _db.Movies.Remove(movie);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}