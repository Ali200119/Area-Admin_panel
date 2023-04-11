using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Data;
using PurpleBuzz.Models;

namespace PurpleBuzz.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Package> packages = await _context.Packages.Where(p => !p.SoftDelete).Include(p => p.Offers).ToListAsync();

            return View(packages);
        }
    }
}