using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using explorestl.Areas.Identity.Data;
using explorestl.Models;
using Google.Apis.SecretManager.v1.Data;
using Microsoft.EntityFrameworkCore;

namespace explorestl.Controllers
{
	[Authorize]
	public class UserCompletedController : Controller
	{

		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SightDbContext _context;

		public UserCompletedController(
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

		// add completed activities to list
		public IActionResult AddCompleted(string formSightId)
		{
			var sightId = Guid.Parse(formSightId);

			var userId = Guid.Parse(_userManager.GetUserId(User));
			var completedCheck = _context.UserCompleteds
				.Any(a => a.UserId == userId && a.SightId == sightId);

			if (completedCheck) return NoContent();

			_context.UserCompleteds.Add(new UserCompleted
			{
				UserId = userId,
				SightId = sightId
			});
			_context.SaveChanges();
			AddCompletedsToViewBag();  
			return NoContent();
		}

		//remove from completed list
		public IActionResult RemoveCompleted(string formSightId)
		{
			var sightId = Guid.Parse(formSightId);

			var userId = Guid.Parse(_userManager.GetUserId(User));
			var userCompleted = _context.UserCompleteds
				.FirstOrDefault(a => a.UserId == userId && a.SightId == sightId);

			if (userCompleted == null) return NoContent();

			_context.UserCompleteds.Remove(userCompleted);
			_context.SaveChanges();
			AddCompletedsToViewBag();
			return NoContent();
		}

		public IActionResult ViewAll()
		{
			AddCompletedsToViewBag();
			return View("~/Views/UserCompleted/CompletedList.cshtml");
		}


		private void AddCompletedsToViewBag()
		{
			var usersCompleteds = _context.UserCompleteds
			   .Where(w => w.UserId == Guid.Parse(_userManager.GetUserId(User)))
			   .ToList();
			var aggregatedCompleteds = new List<Entity>();
			foreach (var userCompleted in usersCompleteds)
			{
				var entity = _context.Entities.Single(e => e.Id == userCompleted.SightId);
				if (entity == null) continue;
				aggregatedCompleteds.Add(entity);
			}

			ViewBag.UserCompleteds = aggregatedCompleteds;
		}
	}
}
