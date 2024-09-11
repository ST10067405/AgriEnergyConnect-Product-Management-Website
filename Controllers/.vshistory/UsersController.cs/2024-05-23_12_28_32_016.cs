using AgriEnergyConnect.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class UsersController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly RoleManager<IdentityUser> _roleManager;

    public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityUser> roleManager)
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

    [HttpPost]
    public async Task<IActionResult> MakeRemoveAdmin(string uId)
    {
        // Find the user based on the provided ID
        var user = await _userManager.FindByIdAsync(uId);
        if (user == null)
        {
            // Handle the case where the user is not found
            return NotFound();
        }

        // Check if the user is currently an admin
        var isAdmin = await _userManager.IsInRoleAsync(user, "Administrator");

        if (isAdmin)
        {
            // If the user is currently an admin, remove the admin role
            await _userManager.RemoveFromRoleAsync(user, "Administrator");
        }
        else
        {
            // If the user is not an admin, add the admin role
            await _userManager.AddToRoleAsync(user, "Administrator");
        }

        // Redirect back to the index page after updating the user's admin status
        return RedirectToAction(nameof(Index));
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

