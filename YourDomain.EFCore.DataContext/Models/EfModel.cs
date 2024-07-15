using YourDomain.Model.Entities;

namespace YourDomain.EFCore.DataContext.Models;

public class EfModel : Entity
{
	public EfModel(string name) : base(name) { }
}
