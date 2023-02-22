using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using N1_WebAplikazioa.Models;

namespace N1_WebAplikazioa.Data;

public class ApplicationDbContext : IdentityDbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {
    }
    public DbSet<N1_WebAplikazioa.Models.Partida> Partida { get; set; } = default!;
    public object Balorazioa { get; set; }
}