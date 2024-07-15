using YourDomain.UseCasesPorts.UseCase.Empty;

namespace YourDomain.UseCases;

public class UseCaseEmpty : IUseCaseInputPort
{
	private readonly IUseCaseOutputPort _outputPort;

	public UseCaseEmpty(IUseCaseOutputPort outputPort)
	{
		_outputPort = outputPort;
	}

	public async ValueTask Handle()
	{
		Console.WriteLine("Hello World");
		// Do something
		await _outputPort.Handle();
	}
}
