using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using ExampleDomain.EfCore;
using ExampleDomain.UseCases;

namespace ExampleDomain.IoC;

public static class DependencyContainer
{
	public static IServiceCollection AddYourDomainServices(
		this IServiceCollection services,
		IConfiguration configuration,
		string connectionStringName)
	{
		services
			.AddYourDomainUseCases()
			.AddYourDomainEfCoreRepositories(configuration, connectionStringName);

		return services;
	}
}
