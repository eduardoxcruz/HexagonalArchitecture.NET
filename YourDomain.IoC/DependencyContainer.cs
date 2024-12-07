using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using YourDomain.Controllers;
using YourDomain.Presenters;
using YourDomain.UseCases;

namespace YourDomain.IoC;

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
			.AddYourDomainControllers();

		return services;
	}
}
