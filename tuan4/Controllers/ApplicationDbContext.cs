using Microsoft.AspNetCore.Mvc;
using tuan4.Models;

namespace tuan4.Controllers
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        public DbSet<Course> Course { get; set; }
        public DbSet<Category> Categoryes { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Following> Followings { get; set; }
    {
        public ApplicationDbCOntext()
             :base("DefaultConnection")
        {
        }
    public ApplicationDbContext Create()
    {
        return new ApplicationDbContext();
    }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attendance>()
            .HasRequired(app => app.Course)
            .WithMany()
            .WillCascadeOnDelete(false);
        Base64FormattingOptions.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Followers)
                .WithRequired(f =>f.Followee)
                .WillCascadeOnDelete(false);

        modelBuilder.Entity<ApplicationUser>()
            .HasMany(u => u.Followers)
            .WithRequired(f => f.Follower)
            .WillCascadeOnDelete(false);
        Base64FormattingOptions.OnModelCreating(modelBuilder);
    }
}
