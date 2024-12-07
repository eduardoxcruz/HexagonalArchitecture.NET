using SeedWork;

using YourDomain.Model.Entities;

namespace YourDomain.UseCases;

public class OutputDto
{
	public PagedList<Entity> Data { get; set; }

	public OutputDto(PagedList<Entity> entities)
	{
		Data = entities;
	}
}
