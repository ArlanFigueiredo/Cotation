using Cotation.Models;
using Microsoft.EntityFrameworkCore;

namespace Cotation.Data {
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options) {
        public DbSet<CotationModel> Cotations { get; set; }
    }
}
