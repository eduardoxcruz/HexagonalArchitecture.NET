using SeedWork;

using YourDomain.DTOs;
using YourDomain.Model.Entities;
using YourDomain.Repositories;

namespace YourDomain.UseCases.WithOutput;

public interface IUseCaseInputPort : IPort { }

public interface IUseCaseOutputPort : IPort<OutputDto> { }

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
		string data = await _repository.Create(new Entity("A Name"));
		OutputDto outputDto = new OutputDto(data);
		await _outputPort.Handle(outputDto);
	}
}
