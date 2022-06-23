using Green_Back_End.DAL;
using Green_Back_End.Models;
using Green_Back_End.View_models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Green_Back_End.Controllers
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
            HomeVM model = new HomeVM
            {
              Sliders = await _context.Sliders.ToListAsync(),
              CardOnes = await _context.CardOnes.ToListAsync(),
              Abouts= await _context.Abouts.FirstOrDefaultAsync(),
              Services = await _context.Services.ToListAsync(),
            };
            
            return View(model);
        }
    }
}
