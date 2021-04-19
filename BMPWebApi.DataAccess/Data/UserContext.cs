using BPMWebApi.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace BPMWebApi.Data {
    public class UserContext : DbContext {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        
    }
}
