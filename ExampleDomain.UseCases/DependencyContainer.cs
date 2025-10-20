using Microsoft.Extensions.DependencyInjection;

namespace ExampleDomain.UseCases;

public static class DependencyContainer
{
	public static IServiceCollection AddYourDomainUseCases(this IServiceCollection services)
	{
		return services;
	}
}
