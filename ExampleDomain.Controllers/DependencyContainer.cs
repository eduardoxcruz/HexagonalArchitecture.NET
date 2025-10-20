using Microsoft.Extensions.DependencyInjection;

namespace ExampleDomain.Controllers;

public static class DependencyContainer
{
	public static IServiceCollection AddYourDomainControllers(this IServiceCollection services)
	{
		return services;
	}
}
