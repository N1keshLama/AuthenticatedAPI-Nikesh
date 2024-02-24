using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticatedAPIN.Data;

public class SecurityContext : IdentityDbContext<IdentityUser>
{
    public SecurityContext(DbContextOptions<SecurityContext> options) : base(options)
{}
}