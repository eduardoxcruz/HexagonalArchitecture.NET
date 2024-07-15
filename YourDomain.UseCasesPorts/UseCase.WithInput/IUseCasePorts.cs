using SeedWork;

using YourDomain.DTOs;

namespace YourDomain.UseCasesPorts.UseCase.WithInput;

public interface IUseCaseInputPort : IPort<InputDto> { }

public interface IUseCaseOutputPort : IPort { }
