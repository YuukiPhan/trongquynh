using Microsoft.AspNetCore.Mvc;

namespace tuan4.Models
{
    public class Attendance : Controller
    {
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public ApplicationUser Attenddee { get; set; }
        public string AttenddeeId { get; set; }
        {
            return View();
        }
    }
}
