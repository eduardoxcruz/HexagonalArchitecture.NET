using SeedWork;

using YourDomain.UseCases.Empty;

namespace YourDomain.Controllers.Empty;

public interface IMyController : IController {}

public class Controller : IMyController
{
	private readonly IUseCaseInputPort _inputPort;
	private readonly IUseCaseOutputPort _outputPort;

	public Controller(IUseCaseInputPort inputPort, IUseCaseOutputPort outputPort)
	{
		_inputPort = inputPort;
		_outputPort = outputPort;
	}

	public async ValueTask RunUseCase()
	{
		await _inputPort.Handle();
	}
}
