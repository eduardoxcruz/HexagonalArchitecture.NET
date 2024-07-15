using YourDomain.UseCases.Empty;

namespace YourDomain.Presenters;

public class PresenterEmpty : IUseCaseOutputPort
{
	public ValueTask Handle()
	{
		return ValueTask.CompletedTask;
	}
}
