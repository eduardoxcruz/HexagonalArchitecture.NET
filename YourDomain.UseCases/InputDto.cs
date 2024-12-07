using SeedWork;

namespace YourDomain.UseCases;

public class InputDto
{
	public PagingParams PagingParams { get; set; }
	public string Data { get; set; }
	
	public InputDto()
	{
		PagingParams = new PagingParams();
	}
}
