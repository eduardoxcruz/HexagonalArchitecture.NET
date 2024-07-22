using SeedWork;

using YourDomain.Model.Entities;
using YourDomain.Model.Repositories;

namespace YourDomain.UseCases.WithInput;

public interface IUseCaseInputPort : IPort<InputDto> { }

public interface IUseCaseOutputPort : IPort { }

public class UseCase : IUseCaseInputPort
{
	private readonly IUseCaseOutputPort _outputPort;
	private readonly IEntityRepository _repository;

	public UseCase(IUseCaseOutputPort outputPort, IEntityRepository repository)
	{
		_outputPort = outputPort;
		_repository = repository;
	}

	public async ValueTask Handle(InputDto dto)
	{
		string data = await _repository.Create(new Entity($"Use Case.WithInput with input dto: {dto.Data}"));
		Console.WriteLine(data);
		await _outputPort.Handle();
	}
}
