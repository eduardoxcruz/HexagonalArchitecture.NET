namespace SeedWork;

public interface IDomainPort<in T>
{
	ValueTask Handle(T dto);
}
