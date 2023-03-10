using Microsoft.AspNetCore.Mvc;

namespace tuan4.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext_dbContext;
    }
    public coursesController()
    {
        _dbContext = new ApplicationDbContext();
    }
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
