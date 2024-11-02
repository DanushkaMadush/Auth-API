using Microsoft.EntityFrameworkCore;
using Auth_API.Models;

namespace Auth_API.Data
{
    public class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options) :base (options) { }
        public DbSet<User> Users { get; set; }

    }
}
