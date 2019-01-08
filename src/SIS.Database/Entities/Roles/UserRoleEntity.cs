using Microsoft.AspNetCore.Identity;
using HirePersonality.Database.Entities.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Database.Entities.Roles
{
    public class UserRoleEntity : IdentityUserRole<int>
    {
        public UserEntity User { get; set; }
        public RoleEntity Role { get; set; }
    }
}
