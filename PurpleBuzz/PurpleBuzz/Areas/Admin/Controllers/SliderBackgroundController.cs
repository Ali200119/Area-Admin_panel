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
    public class SliderBackgroundController : Controller
    {
        private readonly AppDbContext _context;
        public SliderBackgroundController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            SliderBackground sliderBackground = await _context.SliderBackgrounds.Where(sb => !sb.SoftDelete).FirstOrDefaultAsync();

            return View(sliderBackground);
        }

        [HttpGet]
        public async Task<IActionResult> Info(int? id)
        {
            if (id is null) return BadRequest();

            SliderBackground sliderBackground = await _context.SliderBackgrounds.FirstOrDefaultAsync(sb => sb.Id == id);

            if (sliderBackground is null) return NotFound();

            return View(sliderBackground);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            SliderBackground sliderBackground = await _context.SliderBackgrounds.Where(sb => !sb.SoftDelete).FirstOrDefaultAsync();

            if (sliderBackground is null) return NotFound();

            return View(sliderBackground);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}