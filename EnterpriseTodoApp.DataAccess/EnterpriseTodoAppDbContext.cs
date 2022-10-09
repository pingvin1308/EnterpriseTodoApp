using Microsoft.EntityFrameworkCore;

namespace EnterpriseTodoApp.DataAccess;

public class EnterpriseTodoAppDbContext : DbContext
{
    public EnterpriseTodoAppDbContext(DbContextOptions<EnterpriseTodoAppDbContext> options) : base(options)
    {
    }
}
