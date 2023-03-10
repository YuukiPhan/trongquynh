using Microsoft.AspNetCore.Mvc;

namespace tuan4.Models
{
    public class ApplicationDbContext : Controller
    {
        public Dbset<Course> Courses { get; set; }
        public Dbset<Category> Categoryes { get; set; }
        public IActionResult Index()
            : base("Defaultconnection",throwIfV1Schema:false)
            {

            }
        public static ApplicationDbContext Create()
        {
            return ApplicationDbContext();
        }
    }
}
