using Microsoft.AspNetCore.Mvc;

namespace tuan4.Models
{
    public class CouresViewModel : Controller
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public Byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
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
