using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using YourDomain.EFCore.DataContext.Models;

namespace YourDomain.EFCore.DataContext.EntityTypeConfigurations;

public class EfModelEntityTypeConfiguration : IEntityTypeConfiguration<EfModel>
{
	public void Configure(EntityTypeBuilder<EfModel> builder)
	{
		builder.HasNoKey();
		builder.Property(e => e.Name)
			.HasMaxLength(100)
			.IsUnicode(false);
	}
}
