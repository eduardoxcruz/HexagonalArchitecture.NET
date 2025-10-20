namespace SeedWork;

public interface IDomainController<TOutputDto, TInputDto>
{
	ValueTask<TOutputDto> RunUseCase(TInputDto inputDto);
}
