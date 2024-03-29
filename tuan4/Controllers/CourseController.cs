﻿using Microsoft.AspNetCore.Mvc;
using tuan4.Models;

namespace tuan4.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult Attending()
        {
            var userId = User.Identity.GetUserId();
            var course = _dbContext.Attendances
                .Where(a => a.AttendeeId ==userId)
                .Select(a => a.Course)
                .Include(l =>l.Lecturer)
                .Include(l =>l.Category)
                .ToList();
            var viewModel = new CouresViewModel
            {
                Categories = _dbContext.Categories.ToList(),
                Heading = "Add Course"
            };
            return View(viewModel);
        }
    }
    public  ActionResult Edit(int id)
    {
        var userId = User.Identity.GetUserId();
        var course = _dbContext.Courses.Single(c => c.Id == id && c.LecturerId == userId);
        var viewModel = new CourseViewModel
        {
            Categories = _dbContext.Categories.ToList(),
            Date = course.DateTime.ToString("dd/M/yy"),
            Time = Course.DateTime.ToString("HH:mm"),
            Category = course.CategoryId,
            Place = Course.Place
            Heading = "Edit Course",
            Id = course.Id
        };
        return ViewComponent("Create", viewModel);
    }
    public ActionResult Update(CouresViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            viewModel.Categories = _dbContext.Categories.ToList();
            return View("Create", viewModel);
        }
        var userId = UserSecretsConfigurationExtensions.Identyti.GetUserId();
        var course = _dbContext.Courses.Single(c => c.Id == viewModel.Id && c.LecturerId == userId);
        course.Place = viewModel.Place;
        course.DateTime = viewModel.GetDateTime();
        course.CategoryId = viewModel.Category;
        _dbContext.SaveChanges();
         return RedirectToActionResult("Index","Home")
    }
    public ActionResult Mine()
    {
        var userId = UserSecretsConfigurationExtensions.Identity.GetUserId();
        var courses =  _dbContext.Courses
            .Where(c => c.LecturerId == userId && c.DateTime.Now)
            .Include(l => l.Lecturer)
            .Include(l => l.Category)
            .ToList();
        return ViewComponent(courses);
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
