using Microsoft.Extensions.DependencyInjection;

namespace YourDomain.Presenters;

public static class DependencyContainer
{
	public static IServiceCollection AddYourDomainPresenters(
		this IServiceCollection services)
	{
		services.AddScoped<UseCases.Empty.IUseCaseOutputPort, PresenterEmpty>();
		services.AddScoped<UseCases.WithBoth.IUseCaseOutputPort, PresenterWithBoth>();
		services.AddScoped<UseCases.WithInput.IUseCaseOutputPort, PresenterWithInput>();
		services.AddScoped<UseCases.WithOutput.IUseCaseOutputPort, PresenterWithOutput>();

		return services;
	}
}
