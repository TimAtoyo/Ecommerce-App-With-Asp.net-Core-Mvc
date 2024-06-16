namespace eTickets.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using eTickets.Models;
public class AppDbContext: DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
    {
    }

    public DbSet<Actor> Actors { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Movie> Moivies { get; set; }
    public DbSet<Producer> Producers { get; set; }


}