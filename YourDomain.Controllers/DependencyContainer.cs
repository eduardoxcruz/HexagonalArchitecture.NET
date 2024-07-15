using Microsoft.Extensions.DependencyInjection;

namespace YourDomain.Controllers;

public static class DependencyContainer
{
	public static IServiceCollection AddExampleControllers(
		this IServiceCollection services)
	{
		services.AddScoped<WithBoth.IMyController, WithBoth.Controller>();
		services.AddScoped<WithInput.IMyController, WithInput.Controller>();
		services.AddScoped<WithOutput.IMyController, WithOutput.Controller>();
		services.AddScoped<Empty.IMyController, Empty.Controller>();

		return services;
	}
}
