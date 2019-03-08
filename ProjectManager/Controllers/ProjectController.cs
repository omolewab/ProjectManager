using Microsoft.AspNet.Identity;
using ProjectManager.Models;
using ProjectManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManager.Controllers
{
    public class ProjectController : Controller
    {
        private ProjectManagerContext _context;

        public ProjectController()
        {
            _context = new ProjectManagerContext();
        }
        [Authorize]
        // GET: Project
        public ActionResult Create()
        {
            var model = new CreateFormViewModel
            {
                Statuses = _context.Statuses.ToList()
            };
            return View(model);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Statuses = _context.Statuses.ToList();
                return View("Create", viewModel);
            }

            var status = _context.Statuses.Single(t => t.Id == viewModel.Status);
            
            DateTime.TryParseExact(viewModel.Date,
                "dd MMM yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out DateTime dateTime);

            var project = new Project
            {
                UserId = User.Identity.GetUserId(),
                ProjectTitle = viewModel.ProjectTitle,
                ProjectDetails = viewModel.ProjectDetails,
                DateTime = dateTime,
                Status = status,
            };

            //project.Tasks.Add(new Task());

                _context.Project.Add(project);
                _context.SaveChanges();

            string[] tasks = viewModel.Task.Split(',');
            var AppUser = _context.Users.FirstOrDefault(u => u.Email == User.Identity.Name);

            foreach (var tsk in tasks)
            {
                string[] tskDetails = tsk.Split(':');

                ProjectTask newTask = new ProjectTask
                {
                    TaskTitle = tskDetails[0],
                    TaskHandler = tskDetails[1]
                };

                //newTask.Users.Add(AppUser);
                _context.Tasks.Add(newTask);
                project.Tasks.Add(newTask);
                _context.SaveChanges();
  
                UserTasks userTask = new UserTasks
                {
                    UserId = AppUser.Id,
                    TaskId = newTask.Id
                };
                _context.UsersTasks.Add(userTask);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}

//CreateFormViewModel model = new CreateFormViewModel();
//model.Statuses = new List<Status>();