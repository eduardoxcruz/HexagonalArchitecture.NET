using SeedWork;

using YourDomain.DTOs;

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
		Console.WriteLine($"Message: {0}", dto.Data);
		// Do something else
		await _outputPort.Handle();
	}
}
