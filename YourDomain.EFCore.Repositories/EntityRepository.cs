using YourDomain.EFCore.DataContext;
using YourDomain.Model.Entities;
using YourDomain.Repositories;

namespace YourDomain.EFCore.Repositories;

public class EntityRepository : IEntityRepository
{
	private readonly EfDbContext _efDbContext;

	public EntityRepository(EfDbContext efDbContext)
	{
		_efDbContext = efDbContext;
	}
	
	public ValueTask<string> Create(Entity obj)
	{
		throw new NotImplementedException();
	}

	public ValueTask<string> Update(Entity obj)
	{
		throw new NotImplementedException();
	}

	public ValueTask<string> Get(Entity obj)
	{
		throw new NotImplementedException();
	}

	public ValueTask<string> Delete(Entity obj)
	{
		throw new NotImplementedException();
	}
}
