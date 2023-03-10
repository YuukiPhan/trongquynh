using Microsoft.AspNetCore.Mvc;

namespace tuan4.Models
{
    public class ApplicationUser : IdentityUser 
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
