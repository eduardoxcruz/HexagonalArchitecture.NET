using YourDomain.Model.Entities;

namespace YourDomain.Model.Repositories;

public interface IEntityRepository
{
	ValueTask<string> Create(Entity entity);
	ValueTask<string> Update(Entity entity);
	ValueTask<string> Get(Entity entity);
	ValueTask<string> Delete(Entity entity);
}
