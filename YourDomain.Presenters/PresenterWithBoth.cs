using SeedWork;

using YourDomain.DTOs;
using YourDomain.UseCases.WithBoth;

namespace YourDomain.Presenters;

public class PresenterWithBoth : IPresenter<OutputDto>, IUseCaseOutputPort
{
	public OutputDto Content { get; private set; }
    
	public ValueTask Handle(OutputDto dto)
	{
		Content = dto;
		return ValueTask.CompletedTask;
	}
}
