using SeedWork;

using YourDomain.UseCases;
using YourDomain.UseCases.WithBoth;

namespace YourDomain.Controllers.WithBoth;

public interface IMyController : IControllerTOutTIn<OutputDto, InputDto> {}

public class Controller : IMyController
{
	private readonly IUseCaseInputPort _inputPort;
	private readonly IUseCaseOutputPort _outputPort;

	public Controller(IUseCaseInputPort inputPort, IUseCaseOutputPort outputPort)
	{
		_inputPort = inputPort;
		_outputPort = outputPort;
	}
    
	public async ValueTask<OutputDto> RunUseCase(InputDto inputDto)
	{
		await _inputPort.Handle(inputDto);
		return ((IPresenter<OutputDto>)_outputPort).Content;
	}
}
