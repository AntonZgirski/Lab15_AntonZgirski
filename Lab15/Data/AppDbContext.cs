using Lab15.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Lab15.Data
{
  public class AppDbContext : IdentityDbContext
  {
    public readonly IConfiguration _configuration;
    public AppDbContext(IConfiguration configuration)
    {            
      _configuration = configuration;
    }
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }

    public DbSet<Role> Roles { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Emploeyy> Emploeyys { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {      
      optionsBuilder.UseSqlServer(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection"));
    }

  }
}
