using YourDomain.UseCasesPorts.UseCase.WithInput;

namespace YourDomain.Presenters;

public class PresenterWithInput : IUseCaseOutputPort
{
	public ValueTask Handle()
	{
		return ValueTask.CompletedTask;
	}
}
