using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementApi.Data;
using SchoolManagementApi.Models;
using SchoolManagementApi.Repository;

namespace SchoolManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IRepo<Course> repo;

        public CoursesController(IRepo<Course> repo)
        {
            this.repo = repo;
        }

        // GET: api/Courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourse()
        {
           
            var course = await repo.GetAll();
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);  
            
            
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(Guid id)
        {
            ArgumentNullException.ThrowIfNull(id);
            var course = await repo.Get(id);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);
          
        }

        // PUT: api/Courses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse(Guid id, Course course)
        {
            if (id != course.Id)
            {
                return BadRequest();
            }
            repo.Update(course);
            await repo.Save();
            return Ok(course);
           
        }

        // POST: api/Courses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Course>> PostCourse(Course course)
        {
          
            await repo.Create(course);
            await repo.Save();
            return CreatedAtAction("GetCourse", new { id = course.Id }, course);
        }

        // DELETE: api/Courses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(Guid id)
        {
            ArgumentNullException.ThrowIfNull(id);

            var course = await repo.Get(id);
            if (course == null)
            {
                return NotFound();
            }

            repo.Delete(course);
            await repo.Save();

            return NoContent();
        }

        public async Task<IActionResult> FindCourse(string key)
        {
            ArgumentNullException.ThrowIfNull(key);
            var course = await repo.GetByFilter(key);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);

        }
    }
}
