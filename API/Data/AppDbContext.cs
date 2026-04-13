using System;
using Microsoft.EntityFrameworkCore;
using AppUser = API.Entities.AppUser; // Import the AppUser class from the API.Entities namespace to use it in the DbContext.

namespace API.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users {get; set;}
}
