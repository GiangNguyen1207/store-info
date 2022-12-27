using Microsoft.EntityFrameworkCore;

namespace store_info.Models;

public class StoreInfoContext : DbContext
{
    public StoreInfoContext(DbContextOptions<StoreInfoContext> options) : base(options)
    {
    }

    public DbSet<StoreInfo> StoreInfos { get; set; } = null!;
}