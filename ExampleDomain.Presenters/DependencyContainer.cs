using Microsoft.Extensions.DependencyInjection;

namespace ExampleDomain.Presenters;

public static class DependencyContainer
{
	public static IServiceCollection AddYourDomainPresenters(this IServiceCollection services)
	{
		return services;
	}
}
