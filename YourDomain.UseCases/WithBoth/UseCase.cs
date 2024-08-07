﻿using SeedWork;

using YourDomain.Model.Entities;
using YourDomain.Model.Repositories;

namespace YourDomain.UseCases.WithBoth;

public interface IUseCaseInputPort : IPort<InputDto> { }

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

	public async ValueTask Handle(InputDto dto)
	{
		string outData = await _repository.Update(new Entity($"Use Case.WithBoth with input dto: {dto.Data}"));
		OutputDto outputDto = new(outData);
		await _outputPort.Handle(outputDto);
	}
}
