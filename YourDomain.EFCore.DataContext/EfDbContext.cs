using Microsoft.EntityFrameworkCore;

using YourDomain.EFCore.DataContext.EntityTypeConfigurations;
using YourDomain.EFCore.DataContext.Models;

namespace YourDomain.EFCore.DataContext;

public partial class EfDbContext : DbContext
{
	public virtual DbSet<EfModel> EfModels { get; set; }

	public EfDbContext(DbContextOptions<EfDbContext> options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		new EfModelEntityTypeConfiguration().Configure(modelBuilder.Entity<EfModel>());
		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
