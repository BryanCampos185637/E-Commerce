using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Model.Security
{
    public class AplicationRol:IdentityRole
    {
        public List<AplicationUserRol> UserRoles { get; set; }
    }
}
