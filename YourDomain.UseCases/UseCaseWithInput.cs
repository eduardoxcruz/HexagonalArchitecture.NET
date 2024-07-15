using YourDomain.DTOs;
using YourDomain.UseCasesPorts.UseCase.WithInput;

namespace YourDomain.UseCases;

public class UseCaseWithInput : IUseCaseInputPort
{
	private readonly IUseCaseOutputPort _outputPort;

	public UseCaseWithInput(IUseCaseOutputPort outputPort)
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
