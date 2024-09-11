using AgriEnergyConnect.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class UsersController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly RoleManager<ApplicationUser> _roleManager;

    public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationUser> roleManager)
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

    // GET: Users/AddRole
    public IActionResult AddRole(string id)
    {
        ViewBag.UserId = id;
        return View();
    }

    // POST: Users/AddRole
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddRole(string id, string roleName)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }

        if (!await _roleManager.RoleExistsAsync(roleName))
        {
            ModelState.AddModelError(string.Empty, "Role does not exist.");
            return View();
        }

        var result = await _userManager.AddToRoleAsync(user, roleName);
        if (result.Succeeded)
        {
            return RedirectToAction(nameof(Index));
        }
        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }
        return View();
    }

    // GET: Users/RemoveRole
    public async Task<IActionResult> RemoveRole(string id)
    {
        ViewBag.UserId = id;
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }
        var roles = await _userManager.GetRolesAsync(user);
        return View(roles);
    }

    // POST: Users/RemoveRole
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RemoveRole(string id, string roleName)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }
        var result = await _userManager.RemoveFromRoleAsync(user, roleName);
        if (result.Succeeded)
        {
            return RedirectToAction(nameof(Index));
        }
        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }
        return View();
    }

    //// GET: Users/Create
    //public IActionResult Create()
    //{
    //    return View();
    //}

    //// POST: Users/Create
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Create(ApplicationUser model)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
    //        var result = await _userManager.CreateAsync(user, model.PasswordHash);
    //        if (result.Succeeded)
    //        {
    //            await _signInManager.SignInAsync(user, isPersistent: false);
    //            return RedirectToAction(nameof(Index));
    //        }
    //        foreach (var error in result.Errors)
    //        {
    //            ModelState.AddModelError(string.Empty, error.Description);
    //        }
    //    }
    //    return View(model);
    //}

    //// GET: Users/Edit/5
    //public async Task<IActionResult> Edit(string id)
    //{
    //    if (id == null)
    //    {
    //        return NotFound();
    //    }

    //    var user = await _userManager.FindByIdAsync(id);
    //    if (user == null)
    //    {
    //        return NotFound();
    //    }

    //    return View(user);
    //}

    //// POST: Users/Edit/5
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Edit(string id, ApplicationUser user)
    //{
    //    if (id != user.Id)
    //    {
    //        return NotFound();
    //    }

    //    if (ModelState.IsValid)
    //    {
    //        try
    //        {
    //            var existingUser = await _userManager.FindByIdAsync(id);
    //            existingUser.Email = user.Email;
    //            existingUser.UserName = user.Email;
    //            var result = await _userManager.UpdateAsync(existingUser);
    //            if (result.Succeeded)
    //            {
    //                return RedirectToAction(nameof(Index));
    //            }
    //            foreach (var error in result.Errors)
    //            {
    //                ModelState.AddModelError(string.Empty, error.Description);
    //            }
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!UserExists(user.Id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }
    //    }
    //    return View(user);
    //}

    //// GET: Users/Delete/5
    //public async Task<IActionResult> Delete(string id)
    //{
    //    if (id == null)
    //    {
    //        return NotFound();
    //    }

    //    var user = await _userManager.FindByIdAsync(id);
    //    if (user == null)
    //    {
    //        return NotFound();
    //    }

    //    return View(user);
    //}

    //// POST: Users/Delete/5
    //[HttpPost, ActionName("Delete")]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> DeleteConfirmed(string id)
    //{
    //    var user = await _userManager.FindByIdAsync(id);
    //    if (user != null)
    //    {
    //        var result = await _userManager.DeleteAsync(user);
    //        if (result.Succeeded)
    //        {
    //            return RedirectToAction(nameof(Index));
    //        }
    //        foreach (var error in result.Errors)
    //        {
    //            ModelState.AddModelError(string.Empty, error.Description);
    //        }
    //    }
    //    return View("Index", await _userManager.Users.ToListAsync());
    //}

    //private bool UserExists(string id)
    //{
    //    return _userManager.FindByIdAsync(id) != null;
    //}
}

