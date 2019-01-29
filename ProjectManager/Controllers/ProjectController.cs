using ProjectManager.Models;
using ProjectManager.ViewModels;
using System;
using System.Collections.Generic;
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
        // GET: Project
        public ActionResult Create()
        {
            var model = new CreateFormViewModel
            {
                Statuses = _context.Statuses.ToList()
            };
            return View(model);
        }
    }
}

//CreateFormViewModel model = new CreateFormViewModel();
//model.Statuses = new List<Status>();