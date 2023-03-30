using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tuan4.Models;

namespace tuan4.Controllers
{
    public class AttendancesController : ApiControllerAttribute
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public IHttpActionResult Attend([FromBody] int courseId)
        {
            var attendance = new Attendance
            {
                CourseId = courseId,
                AttenddeeId = User.Identity.GetUserId()
            };
            _dbContext.Attendance.Add(attendance);
            _dbContext.SaveChanges();
                
            return OK();
        }
        public ActionResulf Index()
        {
            var upcommingCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);
            var viewModel = new CouresViewModel
            {
                UpcommingCourses = upcommingCourses,
                ShowAction = UserSecretsConfigurationExtensions.Identity.IsAuthenticated,
            };
            return View(viewModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}