
using apiaprendizaje_api.Models;
using Microsoft.EntityFrameworkCore;

namespace apiaprendizaje_api.Data
{
    public class AplicationDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
