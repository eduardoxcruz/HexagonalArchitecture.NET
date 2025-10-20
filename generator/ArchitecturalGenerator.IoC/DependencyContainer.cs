using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using ArchitecturalGenerator.EfCore;
using ArchitecturalGenerator.UseCases;

namespace ArchitecturalGenerator.IoC;

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
