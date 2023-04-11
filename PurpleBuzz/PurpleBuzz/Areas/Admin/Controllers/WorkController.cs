using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Data;
using PurpleBuzz.Models;

namespace PurpleBuzz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;
        public WorkController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Work> works = await _context.Works.Where(w => !w.SoftDelete).Include(w => w.WorkImages).ToListAsync();

            return View(works);
        }

        [HttpGet]
        public async Task<IActionResult> Info(int? id)
        {
            if (id is null) return BadRequest();

            Work work = await _context.Works.Include(w => w.WorkImages).Include(w => w.Category).FirstOrDefaultAsync(w => w.Id == id);

            if (work is null) return NotFound();

            return View(work);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            Work work = await _context.Works.Include(w => w.WorkImages).FirstOrDefaultAsync(w => w.Id == id);

            if (work is null) return NotFound();

            return View(work);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}

