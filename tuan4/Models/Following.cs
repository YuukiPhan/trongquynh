using Microsoft.AspNetCore.Mvc;

namespace tuan4.Models
{
    public class Following : Controller
    {
        public string FollowerId { get; set; }
        public string FolloweeId { get; set; }

        public ApplicationUser Follower { get; set; }
        public ApplicationUser Followee { get; set; }
        public IActionResult Index()
        {
            return View();
        }
    }
}
