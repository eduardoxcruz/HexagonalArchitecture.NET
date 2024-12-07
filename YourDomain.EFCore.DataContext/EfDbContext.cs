using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

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

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EfDbContext>
{
	public EfDbContext CreateDbContext(string[] args)
	{
		
		DbContextOptionsBuilder<EfDbContext> builder = new();
		builder.UseSqlServer("Server=localhost;Database=Testing;User Id=sa;Password=DevPassword123_;Encrypt=False");
		return new EfDbContext(builder.Options);
	}
}
