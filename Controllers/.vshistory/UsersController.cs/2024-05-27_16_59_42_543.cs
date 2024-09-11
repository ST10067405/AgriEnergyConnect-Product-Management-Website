using AgriEnergyConnect.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class UsersController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _roleManager = roleManager;
    }

    // GET: Users
    public async Task<IActionResult> Index()
    {
        var users = await _userManager.Users.ToListAsync();
        return View(users);
    }

    [Authorize(Roles = "Administrator, Employee")]
    [HttpPost]
    public async Task<IActionResult> MakeRemoveFarmer(string uId)
    {
        var user = await _userManager.FindByIdAsync(uId);
        if (user == null)
        {
            return NotFound();
        }

        var isFarmer = await _userManager.IsInRoleAsync(user, "Farmer");

        if (isFarmer)
        {
            await _userManager.RemoveFromRoleAsync(user, "Farmer");
        }
        else
        {
            await _userManager.AddToRoleAsync(user, "Farmer");
        }

        return RedirectToAction(nameof(Index));
    }

    [Authorize(Roles = "Administrator")]
    [HttpPost]
    public async Task<IActionResult> MakeRemoveEmployee(string uId)
    {
        var user = await _userManager.FindByIdAsync(uId);
        if (user == null)
        {
            return NotFound();
        }

        var isEmployee = await _userManager.IsInRoleAsync(user, "Employee");

        if (isEmployee)
        {
            await _userManager.RemoveFromRoleAsync(user, "Employee");
        }
        else
        {
            await _userManager.AddToRoleAsync(user, "Employee");
        }

        return RedirectToAction(nameof(Index));
    }

    [Authorize(Roles = "Administrator")]
    [HttpPost]
    public async Task<IActionResult> MakeRemoveAdmin(string uId)
    {
        var user = await _userManager.FindByIdAsync(uId);
        if (user == null)
        {
            return NotFound();
        }

        var isAdmin = await _userManager.IsInRoleAsync(user, "Administrator");

        if (isAdmin)
        {
            await _userManager.RemoveFromRoleAsync(user, "Administrator");
        }
        else
        {
            await _userManager.AddToRoleAsync(user, "Administrator");
        }

        return RedirectToAction(nameof(Index));
    }

    // GET: Users/DeleteAccount
    public IActionResult DeleteAccount()
    {
        return View();
    }

    // POST: Users/DeleteAccount
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteAccountConfirmed(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user != null)
        {
            await _signInManager.SignOutAsync();
            await _userManager.DeleteAsync(user);
            return RedirectToAction("Index", "Home");
        }
        else
        {
            // Handle case where user is not found
            return NotFound();
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> SelfDeleteAccount()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user != null)
        {
            await _signInManager.SignOutAsync();
            await _userManager.DeleteAsync(user);
            return RedirectToAction("Index", "Home");
        }
        else
        {
            // Handle case where user is not found
            return NotFound();
        }
    }
}