using SeedWork;

using YourDomain.DTOs;
using YourDomain.UseCasesPorts.UseCase.WithOutput;

namespace YourDomain.Presenters;

public class PresenterWithOutput : IPresenter<OutputDto>, IUseCaseOutputPort
{
	public OutputDto Content { get; private set; }
    
	public ValueTask Handle(OutputDto dto)
	{
		Content = dto;
		return ValueTask.CompletedTask;
	}
}
