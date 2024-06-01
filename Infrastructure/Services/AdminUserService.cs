using Infrastructure.Contexts;
using Infrastructure.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.AdminUserService;

public class AdminUserService(UserManager<AdminUserEntity> userManager)
{
    private readonly UserManager<AdminUserEntity> _userManager = userManager;

    

    public async Task<List<AdminUserEntity>> GetAdminUsersAsync()
    {
        return await Task.FromResult(_userManager.Users.ToList());
    }

    public async Task<AdminUserEntity> GetAdminUserByIdAsync(string id)
    {
        return await _userManager.FindByIdAsync(id) ?? null!;
    }

    public async Task<IdentityResult> AddAdminUserAsync(AdminUserEntity user, string password)
    {
        user.CreatedDate = DateTime.UtcNow;
        user.LastModifiedDate = DateTime.UtcNow;
        return await _userManager.CreateAsync(user, password);
    }

    public async Task<IdentityResult> UpdateAdminUserAsync(AdminUserEntity user)
    {
        user.LastModifiedDate = DateTime.UtcNow;
        return await _userManager.UpdateAsync(user);
    }

    public async Task<IdentityResult> DeleteAdminUserAsync(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user != null)
        {
            return await _userManager.DeleteAsync(user);
        }
        return IdentityResult.Failed(new IdentityError { Description = "User not found" });
    }
}
