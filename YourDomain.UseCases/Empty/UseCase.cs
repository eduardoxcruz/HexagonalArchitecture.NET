using SeedWork;

using YourDomain.Model.Entities;
using YourDomain.Model.Repositories;

namespace YourDomain.UseCases.Empty;

public interface IUseCaseInputPort : IPort { }

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

	public async ValueTask Handle()
	{
		string data = await _repository.Get(new Entity("Use Case.Empty"));
		Console.WriteLine(data);
		await _outputPort.Handle();
	}
}
