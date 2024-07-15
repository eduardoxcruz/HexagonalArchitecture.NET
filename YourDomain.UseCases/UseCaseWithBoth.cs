using YourDomain.DTOs;
using YourDomain.Model.Entities;
using YourDomain.Repositories;
using YourDomain.UseCasesPorts.UseCase.WithBoth;

namespace YourDomain.UseCases;

public class UseCaseWithBoth : IUseCaseInputPort
{
	private readonly IUseCaseOutputPort _outputPort;
	private readonly IEntityRepository _repository;

	public UseCaseWithBoth(IUseCaseOutputPort outputPort, IEntityRepository repository)
	{
		_outputPort = outputPort;
		_repository = repository;
	}

	public async ValueTask Handle(InputDto dto)
	{
		string outData = await _repository.Update(new Entity(dto.Data));
		OutputDto outputDto = new OutputDto(outData);
		await _outputPort.Handle(outputDto);
	}
}
