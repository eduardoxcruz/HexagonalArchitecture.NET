using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleDomain.EfCore;

public static class DependencyContainer
{
	public static IServiceCollection AddYourDomainEfCoreRepositories(
		this IServiceCollection services,
		IConfiguration configuration,
		string connectionString)
	{
		services.AddDbContext<EfDbContext>(options => options.UseSqlServer(configuration[$"ConnectionStrings:{connectionString}"]));

		return services;
	}
}
