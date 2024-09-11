using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgriEnergyConnect.Data;
using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AgriEnergyConnect.Controllers
{
    [Authorize(Roles = "Employee, Administrator")]
    public class FarmersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationUser> _roleManager;

        public FarmersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationUser> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: Farmers
        public async Task<IActionResult> Index()
        {
            var usersInFarmerRole = await _userManager.GetUsersInRoleAsync("Farmer");

            return View(usersInFarmerRole);
        }
    }
}
