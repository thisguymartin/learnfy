using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infrastructure;
using Entity;
using Microsoft.EntityFrameworkCore;


namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CoursesController : ControllerBase
  {
    private readonly StoreContext _context;
    public CoursesController(StoreContext context)
    {
      _context = context;

    }

    [HttpGet]
    public async Task<ActionResult<List<Course>>> GetCourses()
    {
      return await _context.Courses.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Course>> GetCoursesById(Guid id)
    {
      return await _context.Courses.FindAsync(id);
    }
  }
}