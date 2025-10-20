using SeedWork;

namespace ArchitecturalGenerator.UseCases.CreateSeedWorkProject;

public class UseCase : IDomainPort<EmptyDto, WorkingPathDto>
{
	public ValueTask<EmptyDto> Handle(WorkingPathDto input)
	{
		return default;
	}
}
