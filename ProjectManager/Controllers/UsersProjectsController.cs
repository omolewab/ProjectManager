using Microsoft.AspNet.Identity;
using ProjectManager.DTOs;
using ProjectManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectManager.Controllers
{
    [Authorize]
    public class UsersProjectsController : ApiController
    {
        private ProjectManagerContext _context;

        public UsersProjectsController()
        {
            _context = new ProjectManagerContext();
        }

        [HttpPost]
        public IHttpActionResult UserProjects (UsersProjectsDTO dto)
        {
            var userId = User.Identity.GetUserId();
            if (_context.UsersProjects.Any(u => u.UserId == userId && u.ProjectId == dto.ProjectId))
                return BadRequest("Project Already Exists.");

            var userprojects = new UsersProjects
            {
                ProjectId = dto.ProjectId,
                UserId = userId
            };
            _context.UsersProjects.Add(userprojects);
            _context.SaveChanges();

            return Ok();
        }
    }
}
