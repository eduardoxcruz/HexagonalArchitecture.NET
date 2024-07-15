using YourDomain.UseCasesPorts.UseCase.Empty;

namespace YourDomain.Presenters;

public class PresenterEmpty : IUseCaseOutputPort
{
	public ValueTask Handle()
	{
		return ValueTask.CompletedTask;
	}
}
