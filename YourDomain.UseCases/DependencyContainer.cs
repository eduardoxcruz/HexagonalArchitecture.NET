using Microsoft.Extensions.DependencyInjection;

namespace YourDomain.UseCases;

public static class DependencyContainer
{
	public static IServiceCollection AddYourDomainUseCases(
		this IServiceCollection services)
	{
		services.AddScoped<Empty.IUseCaseInputPort, Empty.UseCase>();
		services.AddScoped<WithInput.IUseCaseInputPort, WithInput.UseCase>();
		services.AddScoped<WithOutput.IUseCaseInputPort, WithOutput.UseCase>();
		services.AddScoped<WithBoth.IUseCaseInputPort, WithBoth.UseCase>();

		return services;
	}
}
