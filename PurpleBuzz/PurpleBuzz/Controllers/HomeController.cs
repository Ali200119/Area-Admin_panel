using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Data;
using PurpleBuzz.Models;
using PurpleBuzz.ViewModels;

namespace PurpleBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            Service service = await _context.Services.Where(s => !s.SoftDelete).FirstOrDefaultAsync();
            SliderBackground sliderBackground = await _context.SliderBackgrounds.Where(sb => !sb.SoftDelete).FirstOrDefaultAsync();
            IEnumerable<Slider> sliders = await _context.Sliders.Where(s => !s.SoftDelete).ToListAsync();
            IEnumerable<Category> categories = await _context.Categories.Where(c => !c.SoftDelete).ToListAsync();
            IEnumerable<Work> works = await _context.Works.Where(w => !w.SoftDelete).Include(w => w.Category).Include(w => w.WorkImages).ToListAsync();


            HomeVM homeVM = new HomeVM
            {
                SliderBackground = sliderBackground,
                Sliders = sliders,
                Service = service,
                Categories = categories,
                Works = works
            };

            return View(homeVM);
        }
    }
}