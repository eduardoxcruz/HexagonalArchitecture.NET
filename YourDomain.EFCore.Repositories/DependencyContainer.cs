using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using YourDomain.EFCore.DataContext;
using YourDomain.Model.Repositories;

namespace YourDomain.EFCore.Repositories;

public static class DependencyContainer
{
	public static IServiceCollection AddYourDomainEfCoreRepositories(
		this IServiceCollection services,
		IConfiguration configuration,
		string connectionString)
	{
		services.AddDbContext<EfDbContext>(options => options.UseSqlServer(configuration.GetConnectionString(connectionString)));
		services.AddScoped<IEntityRepository, EntityRepository>();

		return services;
	}
}
