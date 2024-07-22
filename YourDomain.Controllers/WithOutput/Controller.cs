using SeedWork;

using YourDomain.UseCases;
using YourDomain.UseCases.WithOutput;

namespace YourDomain.Controllers.WithOutput;

public interface IMyController : IControllerTOut<OutputDto> {}

public class Controller : IMyController
{
	private readonly IUseCaseInputPort _inputPort;
	private readonly IUseCaseOutputPort _outputPort;

	public Controller(IUseCaseInputPort inputPort, IUseCaseOutputPort outputPort)
	{
		_inputPort = inputPort;
		_outputPort = outputPort;
	}
    
	public async ValueTask<OutputDto> RunUseCase()
	{
		await _inputPort.Handle();
		return ((IPresenter<OutputDto>)_outputPort).Content;
	}
}
