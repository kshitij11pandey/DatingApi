using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public  DbSet<AppUser> User{ get; set; }
}
