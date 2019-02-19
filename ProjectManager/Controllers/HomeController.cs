using ProjectManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManager.Controllers
{
    public class HomeController : Controller
    {
        private ProjectManagerContext _context;

        public HomeController()
        {
            _context = new ProjectManagerContext();
        }

        public ActionResult Index()
        {
            var newProjects = _context.Project.ToList();
                
            return View(newProjects);
        }


    }
}