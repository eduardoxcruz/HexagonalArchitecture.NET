namespace SeedWork;

public interface IRepository<TOutput, TInput>
{
	ValueTask<TOutput> Create(TInput obj);
	ValueTask<TOutput> Update(TInput obj);
	ValueTask<TOutput> Get(TInput obj);
	ValueTask<TOutput> Delete(TInput obj);
}
