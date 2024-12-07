using SeedWork;

using YourDomain.Model.Entities;
using YourDomain.Model.Services.Specifications;

namespace YourDomain.UseCases.WithBoth;

public interface IUseCaseInputPort : IPort<InputDto>
{
}

public interface IUseCaseOutputPort : IPort<OutputDto>
{
}

public class UseCase : IUseCaseInputPort
{
	private readonly IUseCaseOutputPort _outputPort;
	private readonly IUnitOfWork _unitOfWork;

	public UseCase(IUseCaseOutputPort outputPort, IUnitOfWork unitOfWork)
	{
		_outputPort = outputPort;
		_unitOfWork = unitOfWork;
	}

	public async ValueTask Handle(InputDto dto)
	{
		EntityWithNameSpecification specification = new(dto.Data, dto.PagingParams);
		PagedList<Entity> entitiesFromDb = await _unitOfWork.Repository<Entity>().FindAsync(specification);
		
		// You can convert the entities to another just by doing:
		PagedList<OtherEntity> entities = new(
			entitiesFromDb.Select(OtherEntity.MapFrom).ToList(),
			entitiesFromDb.TotalCount,
			entitiesFromDb.CurrentPage,
			entitiesFromDb.PageSize);
		// And then pass to outputDto
		
		OutputDto outputDto = new(entitiesFromDb);
		await _outputPort.Handle(outputDto);
	}
}
