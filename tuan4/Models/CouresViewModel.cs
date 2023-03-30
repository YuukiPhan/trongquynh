using Microsoft.AspNetCore.Mvc;

namespace tuan4.Models
{
    public class CouresViewModel : Controller
    {
        public int Id { get; set; }
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public Byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Heading { get; set; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
