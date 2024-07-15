using Microsoft.AspNetCore.Mvc;

using YourDomain.Controllers;
using YourDomain.DTOs;

namespace YourDomain.WebAPI.Controllers;

[Route("api/Example")]
[ApiController]
public class WebApiController : ControllerBase
{
	private readonly YourDomain.Controllers.WithOutput.IMyController _controllerWithOutput;
	private readonly YourDomain.Controllers.Empty.IMyController _controllerEmpty;
	private readonly YourDomain.Controllers.WithInput.IMyController _controllerWithInput;
	private readonly YourDomain.Controllers.WithBoth.IMyController _controllerWithBoth;

	public WebApiController(YourDomain.Controllers.WithOutput.IMyController controllerWithOutput,
							YourDomain.Controllers.Empty.IMyController controllerEmpty, 
							YourDomain.Controllers.WithInput.IMyController controllerWithInput, 
							YourDomain.Controllers.WithBoth.IMyController controllerWithBoth)
	{
		_controllerWithOutput = controllerWithOutput;
		_controllerEmpty = controllerEmpty;
		_controllerWithInput = controllerWithInput;
		_controllerWithBoth = controllerWithBoth;
	}

	[HttpHead]
	[Route("Empty")]
	public async Task<IActionResult> GetEmpty()
	{
		await _controllerEmpty.RunUseCase();
		return Ok();
	}
    
	[HttpGet]
	[Route("WithOutput")]
	public async Task<IActionResult> GetOutputDto()
	{
		OutputDto outputDto = await _controllerWithOutput.RunUseCase();
		return Ok(outputDto);
	}
    
	[HttpPut]
	[Route("WithInput")]
	public async Task<IActionResult> GetInputDto(InputDto inputDto)
	{
		await _controllerWithInput.RunUseCase(inputDto);
		return Ok();
	}
    
	[HttpPost]
	[Route("WithBoth")]
	public async Task<IActionResult> GetBoth(InputDto inputDto)
	{
		OutputDto outputDto = await _controllerWithBoth.RunUseCase(inputDto);
		return Ok(outputDto);
	}
}
