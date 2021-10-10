using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Model.Security
{
    public class AplicationUser: IdentityUser
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<AplicationUserRol> UserRoles { get; set; }
    }
}
