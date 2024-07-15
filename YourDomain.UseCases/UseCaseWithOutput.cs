using YourDomain.DTOs;
using YourDomain.Model.Entities;
using YourDomain.Repositories;
using YourDomain.UseCasesPorts.UseCase.WithOutput;

namespace YourDomain.UseCases;

public class UseCaseWithOutput : IUseCaseInputPort
{
	private readonly IUseCaseOutputPort _outputPort;
	private readonly IEntityRepository _repository;

	public UseCaseWithOutput(IUseCaseOutputPort outputPort, IEntityRepository repository)
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
