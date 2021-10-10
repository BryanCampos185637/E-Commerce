using Microsoft.AspNetCore.Identity;

namespace Model.Security
{
    public class AplicationUserRol:IdentityUserRole<string>
    {
        public AplicationUser User { get; set; }
        public AplicationRol Rol { get; set; }
    }
}
