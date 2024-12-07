using SeedWork;

using YourDomain.Model.Entities;

namespace YourDomain.UseCases.WithInput;

public interface IUseCaseInputPort : IPort<InputDto> { }

public interface IUseCaseOutputPort : IPort { }

public class UseCase : IUseCaseInputPort
{
	private readonly IUseCaseOutputPort _outputPort;

	public UseCase(IUseCaseOutputPort outputPort)
	{
		_outputPort = outputPort;
	}

	public async ValueTask Handle(InputDto dto)
	{
		Console.WriteLine($"Use Case.WithInput with input dto: {dto.Data}");
		await _outputPort.Handle();
	}
}
