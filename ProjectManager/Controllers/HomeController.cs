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
            if (User != null && User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AfterLogin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult AfterLogin()
        {
            var AppUser = _context.Users.FirstOrDefault(u => u.Email == User.Identity.Name);
            var newProjects = _context.Project
           .Include(g => g.Status).Where(p => p.UserId == AppUser.Id);


            return View(newProjects);
        }
    }
}