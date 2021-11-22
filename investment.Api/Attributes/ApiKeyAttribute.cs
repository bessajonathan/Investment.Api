using Investment.Common.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Investment.Attributes
{
    [AttributeUsage(validOn: AttributeTargets.Class | AttributeTargets.Method)]
    public class ApiKeyAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var appSettings = context.HttpContext.RequestServices.GetRequiredService<IOptions<ApplicationSettings>>();

            if (!context.HttpContext.Request.Headers.TryGetValue("x-api-key", out var extractedApiKey))
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                context.Result = new JsonResult(
                       new
                       {
                           Title = "warning",
                           StatusCode = 401,
                           Data = "Não autorizado"
                       });


                return;
            }

            if (!appSettings.Value.ApiKey.Equals(extractedApiKey))
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                context.Result = new JsonResult(
                     new
                     {
                         Title = "warning",
                         StatusCode = 401,
                         Data = "Não autorizado"
                     });
                return;
            }

            await next();
        }
    }
}
