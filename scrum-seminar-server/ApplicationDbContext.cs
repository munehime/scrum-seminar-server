using Microsoft.EntityFrameworkCore;
using scrum_seminar_server.Models;

namespace scrum_seminar_server;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public virtual DbSet<UserModel> Users { get; set; }
    public virtual DbSet<RequestModel> Requests { get; set; }
}