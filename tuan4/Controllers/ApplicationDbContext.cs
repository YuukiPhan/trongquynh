using Microsoft.AspNetCore.Mvc;

namespace tuan4.Controllers
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public 
        public IActionResult Index()
        {
            return View();
        }
    }
}
