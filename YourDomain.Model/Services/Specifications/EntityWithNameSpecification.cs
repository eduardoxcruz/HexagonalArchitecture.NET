using SeedWork;

using YourDomain.Model.Entities;

namespace YourDomain.Model.Services.Specifications;

public sealed class EntityWithNameSpecification : BaseSpecification<Entity>
{
	public EntityWithNameSpecification(string? name, PagingParams pagingParams) : 
		base(entity => (entity.Name.Equals(name)))
	{
		ApplyPaging(pagingParams.PageNumber, pagingParams.PageSize);
	}
}
