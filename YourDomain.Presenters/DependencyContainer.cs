using Microsoft.Extensions.DependencyInjection;

namespace YourDomain.Presenters;

public static class DependencyContainer
{
	public static IServiceCollection AddExamplePresenters(
		this IServiceCollection services)
	{
		services.AddScoped<UseCasesPorts.UseCase.Empty.IUseCaseOutputPort, PresenterEmpty>();
		services.AddScoped<UseCasesPorts.UseCase.WithBoth.IUseCaseOutputPort, PresenterWithBoth>();
		services.AddScoped<UseCasesPorts.UseCase.WithInput.IUseCaseOutputPort, PresenterWithInput>();
		services.AddScoped<UseCasesPorts.UseCase.WithOutput.IUseCaseOutputPort, PresenterWithOutput>();

		return services;
	}
}
