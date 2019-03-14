using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Resume_Builder.Models;

namespace Resume_Builder.Controllers
{
    public class ProjectTeamsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/ProjectTeams
        public IQueryable<ProjectTeam> GetProjectTeams()
        {
            return db.ProjectTeams;
        }

        // GET: api/ProjectTeams/5
        [ResponseType(typeof(ProjectTeam))]
        public IHttpActionResult GetProjectTeam(int id)
        {
            // project = db.Projects.Find(id);
            
            
            
                var team = from employee in db.Employees
                           join projectTeam in db.ProjectTeams on employee.EmployeeId equals projectTeam.EmployeeId
                           join project in db.Projects on projectTeam.ProjectId equals project.ProjectId
                           where projectTeam.ProjectId == id
                           select new
                           {
                               project.ProjectDescription,
                               employee.EmployeeName,
                               projectTeam.Role,
                               projectTeam.EmployeeTech
                           };
                //foreach (var e in team)
                //{
                //    return db.ProjectTeams;
                //}
            
                     
            

            //if (project == null)
            //{
            //    return notfound();
            //}

            return Ok(team);
        }

        // PUT: api/ProjectTeams/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProjectTeam(int id, ProjectTeam projectTeam)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != projectTeam.TeamId)
            {
                return BadRequest();
            }

            db.Entry(projectTeam).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectTeamExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ProjectTeams
        [ResponseType(typeof(ProjectTeam))]
        public IHttpActionResult PostProjectTeam(ProjectTeam projectTeam)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProjectTeams.Add(projectTeam);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = projectTeam.TeamId }, projectTeam);
        }

        // DELETE: api/ProjectTeams/5
        [ResponseType(typeof(ProjectTeam))]
        public IHttpActionResult DeleteProjectTeam(int id)
        {
            ProjectTeam projectTeam = db.ProjectTeams.Find(id);
            if (projectTeam == null)
            {
                return NotFound();
            }

            db.ProjectTeams.Remove(projectTeam);
            db.SaveChanges();

            return Ok(projectTeam);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProjectTeamExists(int id)
        {
            return db.ProjectTeams.Count(e => e.TeamId == id) > 0;
        }
    }
}