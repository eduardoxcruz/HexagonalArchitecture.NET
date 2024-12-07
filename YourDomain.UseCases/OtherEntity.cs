using YourDomain.Model.Entities;

namespace YourDomain.UseCases;

public class OtherEntity
{
	public string Name { get; set; }

	public static OtherEntity MapFrom(Entity source)
	{
		return new OtherEntity() { Name = source.Name };
	}
}
