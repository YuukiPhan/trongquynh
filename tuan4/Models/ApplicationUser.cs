using Microsoft.AspNetCore.Mvc;

namespace tuan4.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> 
    {
        public string Name { get; set; }
       
      public DbSet<Course> Courses { get; set; }
      public DbSet<Category> Categogies { get;set }
      public ICollection<Following> Followers { get; set; }
      public ICollection<Following> Followees { get; set; }
        public ApplicationUser()
        {
            Followers = new CollectionExtensions<Following>();
            Followees = new CollectionExtensions<Following>();
        }

}
