﻿using Microsoft.AspNet.Identity;
using phuocthanh_lab456.Models;
using phuocthanh_lab456.ViewModel;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace phuocthanh_lab456.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }




        //  GET: Courses
        //[Authorize]
        public ActionResult Create()
        {
            var ViewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(ViewModel);
        }

        ////them
        ////asdasdasdas


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(CourseViewModel viewModel)
        {
          
            if (!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        ////th
        [Authorize]
        public ActionResult Attending()
        {
            var userId = User.Identity.GetUserId();
            var courses = _dbContext.Attendances
                .Where(a => a.AttendeeId == userId)
                .Select(a => a.Course)
                .Include(l => l.Lecturer)
                .Include(l => l.category)
                .ToList();

            var ViewModel = new CourseViewModel
            {
                UpcommingCourses = courses,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(ViewModel);
        }
    }
}
