using System;
using BaProject.ExceptionHandling;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BaProject.UI.USERUI.Filters
{
	public class MyExceptionFilter : Attribute, IExceptionFilter, IActionFilter
	{
		public void OnActionExecuted(ActionExecutedContext context)
		{
			throw new NotImplementedException();
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			throw new NotImplementedException();
		}

		public void OnException(ExceptionContext context)
		{
			if (context.Exception is ExceptionBase)
			{
				if (context.Exception is ModelNotValidException)
				{
					var mnValidEx = (ModelNotValidException)context.Exception;
					//home indexi goruntulemek isterken bu hatayi aldi!! 
					//todo log mekanizmasi burada nasil calisacak? ILoggeri nasil kullancaz burda?
					string viewName = context.ActionDescriptor.RouteValues["action"];
					string controllerName = context.ActionDescriptor.RouteValues["controller"];

					var result = new ViewResult();
					foreach (var item in mnValidEx.ValidationMessages)
					{
						
					}

					//result.Model = mnValidEx.ValidationMessages;
					//controllerda excp oldugunda devreye girecek olan islemdir.
					context.Result = new RedirectToActionResult("Index", "Hata", new {HataMesaji= context.Exception.Message});
				}
			}
		}
	}
}
