using SeedWork;

using YourDomain.Model.Entities;

namespace YourDomain.Repositories;

public interface IEntityRepository : IRepository<string, Entity> { }
