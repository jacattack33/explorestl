using Microsoft.AspNetCore.Mvc;  // [Route] , ControllerBase
using Microsoft.CodeAnalysis.CSharp.Syntax;
using explorestl.Areas.Identity.Data;
using explorestl.Models;
using explorestl.ViewModels;

namespace explorestl.Controllers
{
    public class ReviewController : Controller
    {
        private readonly SightDbContext _context;

        public IEnumerable<object> ratings { get; private set; }

        public ReviewController(SightDbContext context)
        {
            _context = context;
        }

        //Get: /<controller>/
        public IActionResult Index()
        {
            List<Review> reviews = _context.Reviews

                .ToList();
            return View(reviews);
        }


        [HttpGet("/Search/Results")]
        public IActionResult AddReview()
        {
            AddReviewViewModel viewModel = new AddReviewViewModel();

            return View(viewModel);
        }

        [HttpPost]
        [Route("/Review")]
        [ValidateAntiForgeryToken]
        public IActionResult ProcessAddReviewForm(AddReviewViewModel addReviewViewModel)
        {
            if (ModelState.IsValid)
            {

                Review newReview = new Review
                {
                    //EntityId = addReviewViewModel.EntityId,
                    DisplayName = addReviewViewModel.DisplayName,
                    ReviewComment = addReviewViewModel.ReviewComment,
                    ReviewTitle = addReviewViewModel.ReviewTitle,
                    Rating = addReviewViewModel.Rating,
                };


                _context.Reviews.Add(newReview);
                _context.SaveChanges();

                return Redirect("/Review");
            }

            return View("AddReview", addReviewViewModel);
        }

    }
}