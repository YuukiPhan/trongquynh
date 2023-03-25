using Microsoft.AspNetCore.Mvc;
using tuan4.Models;

namespace tuan4.Controllers
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        public DbSet<Course> Course { get; set; }
        public DbSet<Category> Categoryes { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
    {
        public ApplicationDbCOntext()
             :base("DefaultConnection")
        {
        }
    }
}
