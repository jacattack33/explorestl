﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using explorestl.Areas.Identity.Data;
using explorestl.Models;

namespace explorestl.Controllers
{
    [Authorize]
    public class UserSightFavoriteController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SightDbContext _context;

        public UserSightFavoriteController(
            SightDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        // add favorites to list
        public IActionResult AddFavorite(string formSightId)
        {
            var sightId = Guid.Parse(formSightId);

            var userId = Guid.Parse(_userManager.GetUserId(User));
            var favoriteCheck = _context.UserSightFavorites
                .Any(a => a.UserId == userId && a.SightId == sightId);

            if (favoriteCheck) return NoContent(); 

            _context.UserSightFavorites.Add(new UserSightFavorite
            {
                UserId = userId,
                SightId = sightId
            });
            _context.SaveChanges();
            AddFavoritesToViewBag();
            return NoContent();
        }

        //remove from favorites list
        public IActionResult RemoveFavorite(string formSightId)
        {
            var sightId = Guid.Parse(formSightId);

            var userId = Guid.Parse(_userManager.GetUserId(User));
            var userFavorite = _context.UserSightFavorites
                .FirstOrDefault(a => a.UserId == userId && a.SightId == sightId);

            if (userFavorite == null) return NoContent();

            _context.UserSightFavorites.Remove(userFavorite);
            _context.SaveChanges();
            AddFavoritesToViewBag();
            return NoContent();
        }

        public IActionResult ViewAll()
        {
            AddFavoritesToViewBag();
            return View("~/Views/UserSightFavorite/_FavoritesList.cshtml"); 
        }


        private void AddFavoritesToViewBag()
        {
            var usersFavorites = _context.UserSightFavorites
               .Where(w => w.UserId == Guid.Parse(_userManager.GetUserId(User)))
               .ToList();
            var aggregatedFavorites = new List<Entity>();
            foreach (var userFavorite in usersFavorites)
            {
                var entity = _context.Entities.Single(e => e.Id == userFavorite.SightId);
                if (entity == null) continue;
                aggregatedFavorites.Add(entity);
            }

            ViewBag.UserFavorites = aggregatedFavorites;
        }
        /*private void AddFavoritesToViewBag()
        {
            var usersFavorites = _context.UserSightFavorites
               .Where(w => w.UserId == Guid.Parse(_userManager.GetUserId(User)))
               .ToList();
            var aggregatedFavorites = new List<Entity>();
            foreach (var userFavorite in usersFavorites)
            {
                var entity = EntityData.FindEntityById(userFavorite.SightId);
                if (entity == null) continue;
                aggregatedFavorites.Add(entity);
            }

            ViewBag.UserFavorites = aggregatedFavorites;
        }*/

    }
}
