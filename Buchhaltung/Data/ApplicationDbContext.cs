using Buchhaltung.Entities;
using Microsoft.EntityFrameworkCore;

namespace Buchhaltung.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : Microsoft.EntityFrameworkCore.DbContext(options)
{
    public DbSet<Account> Accounts { get; set; } = null!;
}