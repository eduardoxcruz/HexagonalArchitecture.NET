using Microsoft.Extensions.DependencyInjection;

namespace ArchitecturalGenerator.UseCases;

public static class DependencyContainer
{
	public static IServiceCollection AddYourDomainUseCases(this IServiceCollection services)
	{
		return services;
	}
}
