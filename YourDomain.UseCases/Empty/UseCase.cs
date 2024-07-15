using SeedWork;

namespace YourDomain.UseCases.Empty;

public interface IUseCaseInputPort : IPort { }

public interface IUseCaseOutputPort : IPort { }

public class UseCase : IUseCaseInputPort
{
	private readonly IUseCaseOutputPort _outputPort;

	public UseCase(IUseCaseOutputPort outputPort)
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
