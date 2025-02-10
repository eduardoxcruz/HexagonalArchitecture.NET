using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace YourDomain.WebAPI.Controllers;

[ApiController]
public class ErrorController : ControllerBase
{
	[ApiExplorerSettings(IgnoreApi = true)]
	[Route("/error-development")]
	public IActionResult HandleErrorDevelopment([FromServices] IHostEnvironment hostEnvironment)
	{
		if (!hostEnvironment.IsDevelopment())
		{
			return NotFound();
		}

		IExceptionHandlerFeature exceptionHandlerFeature =
			HttpContext.Features.Get<IExceptionHandlerFeature>()!;

		return Problem(
			detail: exceptionHandlerFeature.Error.StackTrace,
			title: exceptionHandlerFeature.Error.Message);
	}

	[ApiExplorerSettings(IgnoreApi = true)]
	[Route("/error")]
	public IActionResult HandleError() => Problem();
}
