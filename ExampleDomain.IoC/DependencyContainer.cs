using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using ExampleDomain.Controllers;
using ExampleDomain.EfCore;
using ExampleDomain.Presenters;
using ExampleDomain.UseCases;

namespace ExampleDomain.IoC;

public static class DependencyContainer
{
	public static IServiceCollection AddYourDomainServices(
		this IServiceCollection services,
		IConfiguration configuration,
		string connectionStringName
	)
	{
		services
			.AddYourDomainUseCases()
			.AddYourDomainPresenters()
			.AddYourDomainControllers()
			.AddYourDomainEfCoreRepositories(configuration, connectionStringName);

		return services;
	}
}
