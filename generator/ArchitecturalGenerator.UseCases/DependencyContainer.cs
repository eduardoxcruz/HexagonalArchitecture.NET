using Microsoft.Extensions.DependencyInjection;

using SeedWork;

namespace ArchitecturalGenerator.UseCases;

public static class DependencyContainer
{
	public static IServiceCollection AddYourDomainUseCases(this IServiceCollection services)
	{
		services.AddScoped<IDomainPort<EmptyDto, AddProjectTemplates.ProjectTemplatesPathDto>, AddProjectTemplates.UseCase>();
		
		return services;
	}
}
