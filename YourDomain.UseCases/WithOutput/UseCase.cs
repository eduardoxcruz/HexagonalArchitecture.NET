using SeedWork;

using YourDomain.Model.Entities;

namespace YourDomain.UseCases.WithOutput;

public interface IUseCaseInputPort : IPort { }

public interface IUseCaseOutputPort : IPort<OutputDto> { }

public class UseCase : IUseCaseInputPort
{
	private readonly IUseCaseOutputPort _outputPort;
	private readonly IUnitOfWork _unitOfWork;

	public UseCase(IUseCaseOutputPort outputPort, IUnitOfWork unitOfWork)
	{
		_outputPort = outputPort;
		_unitOfWork = unitOfWork;
	}

	public async ValueTask Handle()
	{
		Entity entity = new("Entity name");
		await _unitOfWork.Repository<Entity>().RemoveAsync(entity);
		PagedList<Entity> entities = await _unitOfWork.Repository<Entity>().FindAsync();
		OutputDto outputDto = new(entities);
		await _outputPort.Handle(outputDto);
	}
}
