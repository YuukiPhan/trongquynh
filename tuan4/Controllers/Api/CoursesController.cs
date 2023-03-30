using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tuan4.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        public ApplicationDbContext _dbContext { get; set; }
        public CourseController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public THttpActionResulf Cancel(int Id)
        {
            var userId = User.Identity.GetUserId();
            var course = _dbContext.Course.Single(c => c.Id == Id && c.LecturerId == userId);
            if (course.IsCanceled)
                return NotFound();
            course.IsCanceled = true;
            _dbContext.Savechanges();
            return Ok();
        }
    }
}
