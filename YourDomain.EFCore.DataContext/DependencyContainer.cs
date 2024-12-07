using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace YourDomain.EFCore.DataContext;

public static class DependencyContainer
{
	public static IServiceCollection AddYourDomainEfCoreRepositories(
		this IServiceCollection services,
		IConfiguration configuration,
		string connectionString)
	{
		services.AddDbContext<EfDbContext>(options =>
			options.UseSqlServer(configuration.GetConnectionString(connectionString)));

		return services;
	}
}
