using SeedWork;

using YourDomain.DTOs;

namespace YourDomain.UseCasesPorts.UseCase.WithBoth;

public interface IUseCaseInputPort : IPort<InputDto> { }

public interface IUseCaseOutputPort : IPort<OutputDto> { }
