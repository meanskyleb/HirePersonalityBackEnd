using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using HirePersonality.Database.DataContract.SeedData;
using HirePersonality.Database.Entities.People;
using HirePersonality.Database.Entities.Roles;

namespace HirePersonality.Database.SeedData
{
    public class SeedRepository : ISeedRepository
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly RoleManager<RoleEntity> _roleManager;

        public SeedRepository(UserManager<UserEntity> userManager, RoleManager<RoleEntity> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void SeedUsers()
        {
            if (!_userManager.Users.Any())
            {
                var roles = new List<RoleEntity>
                {
                    new RoleEntity{Name = "User"},
                    new RoleEntity{Name = "Admin"},
                    new RoleEntity{Name = "Stephen"} 
                };

                foreach (var role in roles)
                {
                    _roleManager.CreateAsync(role).Wait();
                }

                var adminUser = new UserEntity { UserName = "admin" };
                var user = new UserEntity { UserName = "user" };
                var stephen = new UserEntity { UserName = "stephen" };

                #region
                IdentityResult adminResult = _userManager.CreateAsync(adminUser, "password").Result;
                IdentityResult applicantResult = _userManager.CreateAsync(user, "password").Result;
                #endregion
                if (adminResult.Succeeded)
                {
                    var admin = _userManager.FindByNameAsync("admin").Result;
                    _userManager.AddToRolesAsync(admin, new[] { "Admin" }).Wait();
                }
                if (applicantResult.Succeeded)
                {
                    var applicant = _userManager.FindByNameAsync("user").Result;
                    _userManager.AddToRolesAsync(applicant, new[] { "User" }).Wait();
                }
                if (applicantResult.Succeeded)
                {
                    var applicant = _userManager.FindByNameAsync("Stephen").Result;
                    _userManager.AddToRolesAsync(stephen, new[] { "Stephen" }).Wait();
                }
            }
        }
    }
}