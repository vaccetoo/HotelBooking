using HotelBooking.Core.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Web.Controllers
{
	public class ErrorController : Controller
	{
		private readonly ILogger<ErrorController> _logger;

		public ErrorController(ILogger<ErrorController> logger)
		{
			_logger = logger;
		}

		[Route("Error/Handle")]
		public IActionResult Handle()
		{
			var exceptionFeature = HttpContext.Features.Get<IExceptionHandlerFeature>();
			if (exceptionFeature == null)
			{
				return View("Error500");
			}

			var exception = exceptionFeature.Error;

			switch (exception)
			{
				case NotFoundException notFoundEx:
					_logger.LogWarning(notFoundEx, "NotFoundException occurred.");
					Response.StatusCode = 404;
					return View("Error404");

				case ValidationException validationEx:
					_logger.LogWarning(validationEx, "Validation exception occurred.");
					Response.StatusCode = 400;
					ViewBag.Message = string.Join("<br/>", validationEx.Errors);
					return View("Error400");

				case BusinessRuleException businessEx:
					_logger.LogWarning(businessEx, "Business rule exception occurred.");
					Response.StatusCode = 400;
					ViewBag.Message = businessEx.Message;
					return View("Error400");

				default:
					_logger.LogError(exception, "Unhandled exception occurred.");
					Response.StatusCode = 500;
					return View("Error500");
			}
		}
	}
}
