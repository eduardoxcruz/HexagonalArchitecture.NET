using SeedWork;

using YourDomain.DTOs;
using YourDomain.UseCases.WithInput;

namespace YourDomain.Controllers.WithInput;

public interface IMyController : IControllerTIn<InputDto> {}

public class Controller : IMyController
{
	private readonly IUseCaseInputPort _inputPort;
	private readonly IUseCaseOutputPort _outputPort;

	public Controller(IUseCaseInputPort inputPort, IUseCaseOutputPort outputPort)
	{
		_inputPort = inputPort;
		_outputPort = outputPort;
	}
    
	public async ValueTask RunUseCase(InputDto inputDto)
	{
		await _inputPort.Handle(inputDto);
	}
}
