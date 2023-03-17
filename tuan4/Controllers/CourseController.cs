using Microsoft.AspNetCore.Mvc;

namespace tuan4.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult Create()
    }
public ActionResult Create (CourseViewModel viewModel)
{
    if (!ModelState.IsValid)
    {
        viewModel.Categories = _dbContext.Categories.ToList();
        return View("Create", viewModel);
    }
    var course = new Course
    {
        LecturerId = User.Identity.getUserId(),
        DateTime = viewModel.GetDateTime(),
        CategoryId = viewModel.Category,
        Place = viewModel.Place
    };
    _dbContext.Courses.Add(course);
    _dbContext.SaveChanges();
    return RedirectToAction("Index", "Home");
}
