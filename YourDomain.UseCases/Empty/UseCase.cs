using SeedWork;

using YourDomain.Model.Entities;

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
		string data = "Use Case.Empty";
		Console.WriteLine(data);
		await _outputPort.Handle();
	}
}
