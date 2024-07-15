using Microsoft.Extensions.DependencyInjection;

namespace YourDomain.UseCases;

public static class DependencyContainer
{
	public static IServiceCollection AddExampleUseCases(
		this IServiceCollection services)
	{
		services.AddScoped<UseCasesPorts.UseCase.Empty.IUseCaseInputPort, UseCaseEmpty>();
		services.AddScoped<UseCasesPorts.UseCase.WithInput.IUseCaseInputPort, UseCaseWithInput>();
		services.AddScoped<UseCasesPorts.UseCase.WithOutput.IUseCaseInputPort, UseCaseWithOutput>();
		services.AddScoped<UseCasesPorts.UseCase.WithBoth.IUseCaseInputPort, UseCaseWithBoth>();

		return services;
	}
}
