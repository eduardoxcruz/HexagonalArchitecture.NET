using SeedWork;

using YourDomain.DTOs;

namespace YourDomain.UseCasesPorts.UseCase.WithOutput;

public interface IUseCaseInputPort : IPort { }

public interface IUseCaseOutputPort : IPort<OutputDto> { }
