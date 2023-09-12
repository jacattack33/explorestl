using Microsoft.AspNetCore.Mvc;
using explorestl.Areas.Identity.Data;
using explorestl.Models;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;


namespace explorestl.Controllers
{
    public class SearchController : Controller
    {

        private readonly SightDbContext _context;

        public List<Entity> entityList = new List<Entity>();

        public SearchController(SightDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Results(string searchType, string searchTerm, string[] type)
        {
            List<string> selected = new List<string>();

            var entityList = _context.Entities.AsQueryable();

            //If searching all, no need to build query
            if (searchType == "Show Me Everything!")
            {
                ViewBag.entityList = entityList;
                return View();
            }

            //Search based on types
            if (type.Length > 0)
            {
                List<string> selectedTypes = new List<string>();
                foreach (string entityName in type)
                {
                    //uppercase first letter to conform to DB
                    string cleanName = $"{entityName[0].ToString().ToUpper()}{entityName.Substring(1)}";
                    selectedTypes.Add(cleanName);
                }
                entityList = entityList.Where(x => selectedTypes.Contains(x.Type));
            }
            ViewBag.entityList = entityList;
            return View();

        }
    }
}