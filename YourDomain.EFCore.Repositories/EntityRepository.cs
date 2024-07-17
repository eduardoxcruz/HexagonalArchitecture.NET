using YourDomain.EFCore.DataContext;
using YourDomain.Model.Entities;
using YourDomain.Model.Repositories;

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
		return ValueTask.FromResult($"Called Create() method with data: {obj.Name}");
		
	}

	public ValueTask<string> Update(Entity obj)
	{
		return ValueTask.FromResult($"Called Update() method with Data: {obj.Name}");
	}

	public ValueTask<string> Get(Entity obj)
	{
		return ValueTask.FromResult($"Called Get() method with data: {obj.Name}");;
	}

	public ValueTask<string> Delete(Entity obj)
	{
		return ValueTask.FromResult($"Called Delete() method with data: {obj.Name}");
	}
}
