namespace SeedWork;

public interface IDomainPresenter<out T>
{
	public T Content { get; }
}
