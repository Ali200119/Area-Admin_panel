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
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            About about = await _context.Abouts.Where(a => !a.SoftDelete).FirstOrDefaultAsync();
            Team team = await _context.Teams.Where(t => !t.SoftDelete).Include(t => t.TeamMembers).FirstOrDefaultAsync();



            AboutVM aboutVM = new AboutVM
            {
                About = about,
                Team = team
            };

            return View(aboutVM);
        }
    }
}