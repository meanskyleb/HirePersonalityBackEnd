using Microsoft.AspNetCore.Identity;
using HirePersonality.Database.Entities.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Database.Entities.People
{
    public class UserEntity : IdentityUser<int>
    {
        public ICollection<UserRoleEntity> UserRoles { get; set; }
    }
}
