using Buchhaltung.Data;
using Buchhaltung.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Buchhaltung.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController(ApplicationDbContext context) : ControllerBase
{
     [HttpGet]
     public async Task<IEnumerable<Account>> Get(CancellationToken cancellationToken) => 
          await context.Accounts.ToListAsync(cancellationToken);
}